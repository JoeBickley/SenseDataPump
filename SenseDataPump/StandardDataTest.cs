using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Net;
using System.ServiceProcess;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace SenseDataPump
{
    class StandardDataTest
    {
        QRSWebClient qrsClient;

        public string logpath;
        public string serverURL;
        public bool useproxy;
        private int rand;

        public void connect()
        {
            Random rnd = new Random();
            rand = rnd.Next(100, 200);
            qrsClient = new QRSWebClient(serverURL, useproxy);
        }

        private void writeresult(string action, string type, TimeSpan time)
        {
            System.IO.StreamWriter resultfile = new System.IO.StreamWriter(logpath, true);
            resultfile.WriteLine(DateTime.Now + "," + action + "," + type + "," + time.TotalSeconds);
            resultfile.Close();
        }


        public string addTags(int number)
        {
  
            for (int i = 0; i < number; i++)
            {
                
                tag newTag = new tag();

                newTag.name = "Thisisatag - " + rand + "- " + i;

                TimeSpan responsetime = DateTime.Now.TimeOfDay;
                string result = qrsClient.Post("/qrs/tag", JsonConvert.SerializeObject(newTag, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Add", "Tag", responsetime);
            }

            return number + " tags added";
            
        }

        public string addUsers(int UserCount, int attributecount)
        {

            for (int y = 0; y < UserCount; y++)
            {
                user myuser = new user();
                List<userattribute> attributes = new List<userattribute>();


                string attributeval = "Thisisausergroup";

                for (int x = 0; x < attributecount; x++)
                {
                    attributes.Add(new userattribute { attributeType = "group", attributeValue = attributeval + x, externalId = attributeval + x });
                }

                myuser.userDirectory = "TESTDIRECTORY";
                myuser.userId = "TESTUSER" + y;
                myuser.name = "TESTUSER" + y;
                myuser.attributes = attributes;

                TimeSpan responsetime = DateTime.Now.TimeOfDay;
                string result = qrsClient.Post("/qrs/user", JsonConvert.SerializeObject(myuser, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Add", "User", responsetime);
            }

            return UserCount + " users added";

        }

        public string addStreams(int number, bool addrules)
        {

            for (int i = 0; i < number; i++)
            {
                //create a stream object
                stream newStream = new stream();

                newStream.name = "thisisastream - " + rand + "- " + i;

                TimeSpan responsetime = DateTime.Now.TimeOfDay;


                //serialise and post it and get the object back as a response
                string result = qrsClient.Post("/qrs/stream", JsonConvert.SerializeObject(newStream, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

                //deserialise the response so we can get its ID
                newStream = JsonConvert.DeserializeObject<stream>(result);

                if (addrules)
                {
                    //Create a Read Accessrule for the stream and post it
                    systemrule rule = new systemrule();
                    rule.name = "Stream_read_" + newStream.name;
                    rule.resourceFilter = "Stream_" + newStream.ID;
                    rule.comment = "Generated rule to control [read] access for Stream " + newStream.name;
                    rule.rule = "resource.resourcetype=\"Stream\" and (" + Environment.NewLine + "(user.country=\"United States\"))";
                    rule.actions = "2";
                    rule.category = "Security";
                    result = qrsClient.Post("/qrs/systemrule", JsonConvert.SerializeObject(rule, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

                    //Create a publish Accessrule for the stream and post it
                    rule = new systemrule();
                    rule.name = "Stream_publish_" + newStream.name;
                    rule.resourceFilter = "Stream_" + newStream.ID;
                    rule.comment = "Generated rule to control [publish] access for Stream " + newStream.name;
                    rule.rule = "resource.resourcetype=\"Stream\" and (" + Environment.NewLine + "(user.userId=\"" + Environment.UserName + "\"))";
                    rule.actions = "32";
                    rule.category = "Security";
                    result = qrsClient.Post("/qrs/systemrule", JsonConvert.SerializeObject(rule, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
                }

                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Add", "Stream", responsetime);

            }

            return number + " streams added";

        }

        public string addApps(int number, string testapp)
        {
   
            //Add first
            TimeSpan duration = DateTime.Now.TimeOfDay;
            app oneapp;
            Dictionary<string, string> queries = new Dictionary<string, string>();

            if(testapp.Length==0)
            {
                System.IO.File.WriteAllBytes(System.IO.Path.GetTempPath() + @"\TestApp.qvf", Properties.Resources.Test_App);
                testapp = System.IO.Path.GetTempPath() + @"TestApp.qvf";
            }
            

            queries.Add("name", "Thisisanapp - " + rand);
            string postfileresult = qrsClient.PostFile("/qrs/app/upload", testapp, queries);
            oneapp = JsonConvert.DeserializeObject<app>(postfileresult);

            duration = DateTime.Now.TimeOfDay - duration;
            writeresult("Add", "App", duration);

            //copy it several times
            duration = DateTime.Now.TimeOfDay;
            for (int i = 0; i < number - 1; i++)
            {
                TimeSpan responsetime = DateTime.Now.TimeOfDay;

                queries = new Dictionary<string, string>();
                queries.Add("name", oneapp.name + "-" + (i + 1));
                string result = qrsClient.Post("/qrs/app/" + oneapp.ID + "/copy", "", queries);

                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Copy", "App", responsetime);

            }

            return number + " apps added";

        }

        public string addDataConnections(int number)
        {
     
            for (int i = 0; i < number;i++ )
            {
                dataconnection newCon = new dataconnection();
                newCon.name = "DB connection - " + rand + "- " + i;
                newCon.connectionstring = "Conn string to database";
                newCon.type = "ODBC";
                newCon.username = "username";
                newCon.password = " secret password";


                TimeSpan responsetime = DateTime.Now.TimeOfDay;
                string result = qrsClient.Post("/qrs/dataconnection", JsonConvert.SerializeObject(newCon, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Add", "DataConnection", responsetime);

            }

            return number + " data connections added";

        }

        public string addLicenceConfig(int number, bool addrules)
        {
      
            for (int i=0;i<number;i++)
            {
                LoginLicenceType newRule = new LoginLicenceType();
                newRule.name = "Allocation of Logins - " + rand + "- " + i;
                newRule.assignedTokens = "1";

                TimeSpan responsetime = DateTime.Now.TimeOfDay;

                string result = qrsClient.Post("/qrs/license/loginaccesstype", JsonConvert.SerializeObject(newRule, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

                newRule = JsonConvert.DeserializeObject<LoginLicenceType>(result);

                if (addrules)
                {
                    
                    //Create an Accessrule for the type and post it
                    systemrule rule = new systemrule();
                    rule.name = "License.LoginAccessType_useaccesstype_" + newRule.name;
                    rule.resourceFilter = "License.LoginAccessType_" + newRule.ID;
                    rule.comment = "Generated rule to control [useaccesstype] access for License.LoginAccessType " + newRule.name;
                    rule.rule = "resource.resourcetype=\"License.LoginAccessType\" and (" + Environment.NewLine + "(user.userDirectory=\"xx\"))";
                    rule.actions = "1";
                    rule.category = "License";                  
                    
                    result = qrsClient.Post("/qrs/systemrule", JsonConvert.SerializeObject(rule, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

                    
                }

                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Add", "LicenceRule", responsetime);


            }

            return number + " licence allocations added";




        }

        public string addCustomProperties(int number)
        {
            for (int i = 0; i < number;i++ )
            {

                CustomProperty newProp = new CustomProperty();

                newProp.name = "CP" + rand + "x" + i;
                newProp.valueType = "Text";
                newProp.objectTypes = new string[] { "App", "ServerNodeConfiguration", "DataConnection", "EngineService", "ProxyService", "ReloadTask", "SchedulerService", "Stream", "User" };
                newProp.choiceValues = new string[] { "High", "Medium", "Low" };

                TimeSpan responsetime = DateTime.Now.TimeOfDay;

                string result = qrsClient.Post("/qrs/custompropertydefinition", JsonConvert.SerializeObject(newProp, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Add", "CustomProperty", responsetime);
                          
            }

            return number + " custom properties added";

        }


        public string addTaskChainApps(int number, int chaindepth)
        {

            System.IO.File.WriteAllBytes(System.IO.Path.GetTempPath() + @"\InitialSalesDataExtract.qvf", Properties.Resources.InitialSalesDataExtract);
            System.IO.File.WriteAllBytes(System.IO.Path.GetTempPath() + @"\SalesQVDload.qvf", Properties.Resources.SalesQVDLoad);
            System.IO.File.WriteAllBytes(System.IO.Path.GetTempPath() + @"\TransformSalesData.qvf", Properties.Resources.TransformSalesData);
            System.IO.File.WriteAllBytes(System.IO.Path.GetTempPath() + @"\Sales.qvf", Properties.Resources.Sales);




            for (int rep = 100; rep < 100 + number; rep++)
            {
                TimeSpan responsetime = DateTime.Now.TimeOfDay;

                app kickoff;
                app combine;
                List<app> QVDLoaders;
                List<app> UserApps;

                QVDLoaders = new List<app>();
                UserApps = new List<app>();

                Dictionary<string, string> queries = new Dictionary<string, string>();
                queries.Add("name", rep + "_Kick off task chain ");
                string postfileresult = qrsClient.PostFile("/qrs/app/upload", System.IO.Path.GetTempPath() + @"\InitialSalesDataExtract.qvf", queries);
                kickoff = JsonConvert.DeserializeObject<app>(postfileresult);


                queries = new Dictionary<string, string>();
                queries.Add("name", rep + "_Transform Sales Data ");
                postfileresult = qrsClient.PostFile("/qrs/app/upload", System.IO.Path.GetTempPath() + @"\TransformSalesData.qvf", queries);
                combine = JsonConvert.DeserializeObject<app>(postfileresult);


                for (int i = 1; i <= chaindepth; i++)
                {

                    queries = new Dictionary<string, string>();
                    queries.Add("name", rep + "_Data Loader " + i);
                    postfileresult = qrsClient.PostFile("/qrs/app/upload", System.IO.Path.GetTempPath() + @"\SalesQVDload.qvf", queries);
                    app appresult = JsonConvert.DeserializeObject<app>(postfileresult);


                    QVDLoaders.Add(appresult);

                }

                for (int i = 1; i <= chaindepth; i++)
                {                    
                    queries = new Dictionary<string, string>();
                    queries.Add("name", rep + "_User App " + i);
                    postfileresult = qrsClient.PostFile("/qrs/app/upload", System.IO.Path.GetTempPath() + @"\Sales.qvf", queries);
                    app newapp = JsonConvert.DeserializeObject<app>(postfileresult);

                    UserApps.Add(newapp);
                    //publish it
                    //publishApp(newapp, "Global Sales");
                }

                buildTaskChain(kickoff, combine, QVDLoaders, UserApps, rep);

                responsetime = DateTime.Now.TimeOfDay - responsetime;
                writeresult("Add", "TaskChain", responsetime);
            }

            return number + " task chains added";
        }

        private void buildTaskChain(app kickoff, app combine, List<app> dataloaders, List<app> userapps, int rep)
        {

            string taskresult;

            List<task> QVDloadtasks = new List<task>();


            //Create Kick of task
            task kickofftask;
            kickofftask = new task();
            kickofftask.app = kickoff;
            kickofftask.enabled = false;
            kickofftask.taskType = 0;
            kickofftask.name = "Reload of :" + kickoff.name;

            //timetrigger for kick off task

            List<schemaEvent> triggers = new List<schemaEvent>();

            schemaEvent newevent = new schemaEvent();
            newevent.enabled = true;
            newevent.daylightSavingTime = 0;
            newevent.eventType = 0;
            newevent.incrementDescription = "15 0 0 0";
            newevent.incrementOption = 0;
            newevent.name = "hourly";
            newevent.timeZone = "UTC";
            newevent.schemaFilterDescription = new string[] { "* * - * * * * *" };
            newevent.startDate = "2016-06-23T20:45:10.000Z";
            newevent.expirationDate = "9999-01-01T00:00:00.000Z";



            triggers.Add(newevent);

            ReloadObject taskandtrigger = new ReloadObject();
            taskandtrigger.task = kickofftask;
            taskandtrigger.schemaEvents = triggers.ToArray();

            string xTask = JsonConvert.SerializeObject(taskandtrigger, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            taskresult = qrsClient.Post("/qrs/reloadtask/create", xTask);


            kickofftask = JsonConvert.DeserializeObject<task>(taskresult);



            //Create QVDLoaderTriggers
            ReloadObject ReloadChain = new ReloadObject();

            foreach (app app in dataloaders)
            {


                task childtask = new task();
                childtask.app = app;
                childtask.enabled = true;
                childtask.taskType = 0;
                childtask.name = "Reload of :" + app.name;

                List<compositeEvent> CompEvents = new List<compositeEvent>();
                List<compositeRule> CompRules = new List<compositeRule>();

                compositeRule aRule = new compositeRule();
                aRule.reloadTask = kickofftask;
                aRule.ruleState = "TaskSuccessful";

                CompRules.Add(aRule);

                timeConstraint TS = new timeConstraint();
                TS.days = 0;
                TS.hours = 6;
                TS.minutes = 0;

                compositeEvent aEvent = new compositeEvent();
                aEvent.name = "FollowInitialExtract";
                aEvent.eventType = 1;
                aEvent.compositeRules = CompRules.ToArray();
                aEvent.enabled = true;
                aEvent.timeConstraint = TS;

                CompEvents.Add(aEvent);

                ReloadChain.task = childtask;
                ReloadChain.compositeEvents = CompEvents.ToArray();

                string sTask = JsonConvert.SerializeObject(ReloadChain, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                taskresult = qrsClient.Post("/qrs/reloadtask/create", sTask);

                QVDloadtasks.Add(JsonConvert.DeserializeObject<task>(taskresult));

            }

            //ConsolidateTask

            ReloadChain = new ReloadObject();
            task consolidatetask = new task();
            consolidatetask.app = combine;
            consolidatetask.enabled = true;
            consolidatetask.taskType = 0;
            consolidatetask.name = "Reload of :" + combine.name;

            List<compositeEvent> ConsolidateCompEvents = new List<compositeEvent>();
            List<compositeRule> ConsolidateCompRules = new List<compositeRule>();

            for (int i = 0; i < QVDloadtasks.Count; i++)
            {
                compositeRule ConsolidateRule = new compositeRule();
                ConsolidateRule.reloadTask = QVDloadtasks[i];
                ConsolidateRule.ruleState = "TaskSuccessful";

                ConsolidateCompRules.Add(ConsolidateRule);
            }

            timeConstraint TS2 = new timeConstraint();
            TS2.days = 0;
            TS2.hours = 6;
            TS2.minutes = 0;

            compositeEvent newEvent = new compositeEvent();
            newEvent.name = "Follow all sales QVDs";
            newEvent.eventType = 1;
            newEvent.compositeRules = ConsolidateCompRules.ToArray();
            newEvent.enabled = true;
            newEvent.timeConstraint = TS2;

            ConsolidateCompEvents.Add(newEvent);

            ReloadChain.task = consolidatetask;
            ReloadChain.compositeEvents = ConsolidateCompEvents.ToArray();

            string Task = JsonConvert.SerializeObject(ReloadChain, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            taskresult = qrsClient.Post("/qrs/reloadtask/create", Task);

            consolidatetask = JsonConvert.DeserializeObject<task>(taskresult);

            // second level children

            foreach (app app in userapps)
            {

                task childtask = new task();
                childtask.app = app;
                childtask.enabled = true;
                childtask.taskType = 0;
                childtask.name = "Reload of :" + app.name;

                List<compositeEvent> CompEvents = new List<compositeEvent>();
                List<compositeRule> CompRules = new List<compositeRule>();

                compositeRule aRule = new compositeRule();
                aRule.reloadTask = consolidatetask;
                aRule.ruleState = "TaskSuccessful";

                CompRules.Add(aRule);

                timeConstraint TS = new timeConstraint();
                TS.days = 0;
                TS.hours = 6;
                TS.minutes = 0;

                compositeEvent aEvent = new compositeEvent();
                aEvent.name = "Follow Transform of QVDs";
                aEvent.eventType = 1;
                aEvent.compositeRules = CompRules.ToArray();
                aEvent.enabled = true;
                aEvent.timeConstraint = TS;

                CompEvents.Add(aEvent);

                ReloadChain.task = childtask;
                ReloadChain.compositeEvents = CompEvents.ToArray();

                string sTask = JsonConvert.SerializeObject(ReloadChain, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                taskresult = qrsClient.Post("/qrs/reloadtask/create", sTask);


            }

        }

    }
}
