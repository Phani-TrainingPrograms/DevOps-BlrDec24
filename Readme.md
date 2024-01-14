# Dev Ops Training by Phaniraj @phani.blrtraining@gmail.com
## Subtopics:
1. DevOps
2. Git
3. Docker
4. jenkins
5. Microservices and Orchestrazation. 
6. Kubernetes(K8s)


### What is DevOps?
- There will be 2 teams who collaborate in the Project Deployment cycle. Developer team and the operations team. 
- The developer team will be responsible for Requirement Gathering, Designing, Developing Unit testing, Implementation, Integration and Finally Deployment. 
The stakeholders would be the Product owner, Manager, Team Leads, Senior Programmres, Programmers and QA Team.
- The Operations team will be responsible for Automation Testing, App Evaluation, Integrations and final Deployment. 
- User Acceptance Test will be conducted by one user of the Application(Customer) who understands the process very well and the Application Execution. He/She will ensure that the App meets the requirements in an expected manner. 
- The stake holders would be Automation Testers, Product evaluators, UAT Engineers and customer users who use UR Product. 

#### Challenges in this setup
- Many a time, the Operations team are not aware of the technical parts required for the Application. Even if small modifications are required, they fail to work on the same and resolve it. 
- Integration of multiple config files across the solution will be huge. Sometimes, it might take days to resolve it. 
- Applications are expected to be created partially, deployed and continue the development of the Application: Continuous Integration/Deployment. (CI/CD).
- The solution for all the above problems is Dev + Ops to go together. 
- Dev + Ops will work together from the begining during the Sprint Cycles and do collaborative work on resolving deployment issues like versioning of packages that U use in your App development and helping each other in understanding both the sides of the Project execution. 

### Why DevOps?
- Before DevOps, the Dev and Ops were seperate entities and worked in complete Isolation. But here, with this mindset, the Testing and Development team were isolated and testing was done always after the complete development is done. This consumed more time than the regular short build cycles. Unexpected challenges used to popup with no clue from the developer team. Manual Code deployment used to ahve some human errors in the production Environment that used to take days to resolve.
- With DevOps, S/W delivery is fast and easy. It increases the Deployment easiness. DevOps maintains History which helps in fastening the futher Deployment processes as you have a certain experience over UR previous deployment of the last Sprint. According to the Industry analysts, the Deployments done thru DevOps have increased the speed of the Total Application Delivery(TAD) by over 20%.
- Many of these operations are automated using well tested and popular Tools to do UR work. Git, Docker, Jenkins, Kubernetes are some of the major tools that help in fastening the activities during the development and deployment. 

### How Apps are deployed in Real Time?
With Agile Development methodology, UR Scrum master will plan the sprints. Sprints are short span targets that are realistic and supposed to be met  with the scope of development to be a minor one. The duration of the sprint will be ideally 2-3 weeks. There will be a Sprint planning that includes the divisions of the tasks and given priority, decide on the resources for each task etc. The participants would be 1 Lead, 2 Sr. Engineers, 3 Jr Engineers and a Tester. Initially a Devops person will also be available who sets up the process and explains to the team on how to push the code into the Repository for the CI/CD. During the time, the developers and testers would do the Unit tests and set up the environment for Automation Testing so that when the developer push the code to the REPO, the CI/CD would happen thru tools that will automate the build, Test and Deploy Process. Tools like Git(REPO), Jenkins(CI), Docker(Containers) and K8s (Containerization) will help in this process to make UR Application a success.

### Practical Scenario:
1. Task: Get All Employees from a Database
2. Step1: Create a DB or Mock a database using mocking tools like gmock. 
3. Step2: Create the required unit test cases and run the cases on the mock database. It should fail as no code is developed. 
4. Step3: Implement the required code to make the feature work. Run the tests and make it successfull. 
5. Step4: Review the code under the internal review
6. Step5: Push the code into the Code Repo like git or TFS.
7. Step6: Once the code is pushed, a CI/CD tool will build the project, run the linting tools and automation tests along with e2e Testing
8. Step7: On any failure, email notifications will be sent to the respective stake holders to rearrange the setup. 
9. Step8: On the successful build, the Post build operations will continue which might be deploying the EXE on a real server which could be on cloud or place it in a container like Docker. 
10: Step9: Once the services are placed in containers, it will be managed by the Container management tool like K8s for going live. 
11: Step10: Finally the Consuming App is deployed on the cloud like AWS and allowed to be used online by the end customers. 

### Benifits of DevOps:
1. Productivity
2. Reproducability. 
3. Maintainability. 

### What kind of Apps can use DevOps?
- Large Distributed Apps like E-Commerce and Distributed Enironments(Apps that are installed in multiple places and consumed by users at various levels and time) and hosted in Cloud based Environments. 
- With Agile Development methodology, it is easy to practise DevOps using the CI/CD Tool and central code repositories like Git. 

### DevOps Automation tools:
1. Git Repositories for storing the code and version maintainability. 
2. Jenkins for Continuous Integration and Deployment.
3. Log4J and Splunk for logging and storing purposes. 
4. Docker for virtualization of the Application/Service. 
5. K8s for maintaining clustors of Docker Containers that run on various parts of different apps and providing continuous services without much breakdown. 
--------------------------------------------------------------------------------------------------
# Git:
--------------------------------------------------------------------------------------------------
# Docker:
- Docker is a containerization platform for packaging, deploying and running the Application in a closed Environment. 
- Docker provides a capability to replicate the dev Env into the Prod Env using Dockerfile. 
- Dockerfile is a set of instructions that defines what min dependencies UR code needs to execute. the Required dependenies will be loaded into the container before UR code executes.
- For eg: If I need to run a java App, I need an appropriate JDK and the src code required.
- Docker uses a concept called Containers that will create a closed Environment and place UR Code inside it. With this containers, U connect UR App and other Apps into this and make sure that the App will not fail and face any deployment complexity while running. 
- Docker can be installed either on Linux or Windows. Even Windows OS can have Linux kernel and install the Docker in it.

### Installing the Docker:
1. Install the WSL(Windows Subsystem for Linux) in UR machine. This is available as a part of the Windows Components which can be installed from the Programs and features. Then U should run the command wsl to install
```
wsl --install
```
2. U should restart the machine after the installation. 
3. Run the msi file of the Docker to allow the installation of Docker Envinronment. 
4. Docker will start immediately after the installation and one must wait till the docker starts. 
5. U can use the Docker UI for Desktop to create containers, images and execute them in UR machines. 


#### Installing Mongodb in UR Docker
1. Run the following commands in the order to install and run the MongoDB inside your docker
```
docker pull mongodb/mongodb-community-server
docker run --name mongo -d mongodb/mongodb-community-server:latest
docker container ls
docker exec -it mongo mongosh
show dbs
```
### Installing a Java App in Docker
1. Create a new Folder for creating UR Java App
2. Create the Required Java files for UR Application. 
3. Build the Application and Test it. 
4. After the build is successfull and tested, it is now time to push the App to Docker.
5. Remove the temp files created while building (Includes the .class files, debug files etc). 
6. Create a Dockerfile, a Text file with no extension and name should be Dockerfile. Provide the appropriate instructions starting with FROM till CMD.
7. Run the following commands to push the Application to the Docker container and run it in an order. if the build is successfull, an image would be created in the Docker. 
```
docker build -t java-app .
docker run java-app
```
8. When U run the Image, it creates a container in which UR App executes. 
<b>options:</b>
1. -t => Flag that tells the Docker to allocate Virtual Terminal within the Container to start UR Program and view the results. 
2. -i =>Flat U set while running the Program in interactive mode, usefull when you have to take inputs from the User. 
---------------------------------------------------------------------------------------------------

## Jenkins
### What is Continuous Integration?
- A chain(Orchestrazation) of activities that should be performed in an automatted scence starting from the Code push to the repository to deploying it to the Cloud/Container/Server that is ready for final usage. 
- All these things are to be conducted without an explicit resource(Human).
- This is called CIT(Continuous Integration Tool). It keeps track of the various builds that are conducted frequently and execute a post build operation to either deploy and run another set of operations relative to the dependencies of the current Application. 
- These series of tasks could start from pulling the code from the REPO, setting up the required options for building the Application in the Environment, test the code at all levels(Unit, Integration, e2e) and finally push the code to the destination environment. 
- It should also handle the failure scenarios, it shall stop the build, send email notifications to all the stake holders and stop the further steps of execution.    
- The most popular CIT available is JENKINS.

### How JENKINS Work?
- It is basically a web server application based on Java that runs on Apache Tomcat web server. It can run on multiple platforms. To use Jenkins, we create pipelines that contain automated processes that has execute in a time bound manner. 
- Jenkins internally use the 3rd party libraries and the tools to build, test and monitor the application sequence, raising reports and triggering email notifications. These tools could be git, linting tools, email services, dependency services and many more. They are made available thru' plugins. 

### Install and run JENKINS to build a Java App pipeline
1. Download JDK 8.0 or later in UR machine.
2. Download the Jenkins from the website 
3. During the installation, the wizard asks for the jdk location which U should provide. 
4. U could optionally set the port no for accessing the Jenkins App.
5. When U login for the first time, U should provide the username as Admin and password taken from the secret password available at C:\ProgramData\Jenkins\.jenkins\secrets\initialAdminPassword. However, U can change the password later. 
6. Open the Jenkins App on the browser with address: http://localhost:5000

### Creating Jobs in JENKINS
1. Job is a simple task that is expected to be streamlined by the CIT when a push is triggered in the repo or a time based operation. 
2. Create the required code and push the code into the repo. 
3. Click the new item that is found in the Jenkins Dashboard and select the options appropriately and make it saved in the Jenkins pipeline. 
4. U could provide details like: name, description, repo urls or local repo, pre build, post build operations. 
5. For local repos, select custom workspace under Advanced sub-section of the General section. 
6. The build process can include a batch file to be executed.  usually batch file can be inserted or the commands could be placed directly into the dialog box. 
7. U can maintain periodic Builds using the Periodic Build section and define the automated time interval based on Cron time settings followed in Linux. 
-------------------------------------------------------------------------------------------------
## Microservices
1. Dividing the Application into small independent Units that can be deployed in container tools like docker and consumed on various platforms. Creating a service is very feature in all the technologies like Java(Springboot), .NET Core(Web API), Nodejs(Express) and many more. 
2. Microservice is exposed to the outside world using service brokers. The service brokers use API gateways to publish the services to the rest of the world. 
3. One must register their services to these api gateways to make it available for all external users. 
4. U can even create Server less APIs using AWS Lambda.

### Creating a Microservice in .NET CORE and placing it in Docker. 
#### Software requirements:
1. Windows 10 or later OS
2. Visual Studio 2022 with docker, .net core and web development tools selected in installer. 
3. Docker for Windows.
4. Optionally U can also install Docker Tools for Visual Studio.

#### Creating the Application:
1. VS 2022 should be selected. Create a Project of the type ASP.NET CORE WEB API. 
2. Create the required Data classes
3. Create the Controllers requried for the Application. 
4. Create the requried docker files. 
5. If connecting to SQL server, create the image of the SQL server in docker
6. Using YAML, U provide the network b/w the Application Container and SQL server container. This feature is called as Orchestration feature.
7. Build the Application and run the App to expose the App into the Docker.
8. Open the Package Manager Tool Window and run the following commands to generate the required tables:
    - add-migration mig1.
    - update-database
9. U can test the API using the Swagger window that opens when the App starts.      
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Kubernetes(K8s)
- It is a container management system developed on Google platform. It's main purpose is helping in managing the Containerized Apps on various platforms like cloud, Virtual Servers and local servers. It is said to be one of the most popular Container management Tools. 
- It is purely a cloud based environment. It comes with many automation tools that will be used to maintain the large scale containers as one Unit. 
- As DevOps Engineer, one will get skills on using these automation tools to manage the Applications and ensure that no break down of the software happen. 
- It uses a concept called CLUSTERS where each cluster is a repository of 100s of containers grouped into Worker nodes or PODs. Each POD might be an Application that has multiple containers in it. Each container can have one or more Microservices in it. 
- K8s maintain multiple clusters for the management of the nodes. The Application will be available to user thru Primary Cluster. If the primary cluster fails for maintainence or any other reason, a secondary cluster will be made available for the Application to continue its services to the Customer. Once the Primary Cluster is back to work, a cached state of the secondary cluster is pushed into the Primary one and the Application continues to provide the services. 

### How K8s work?
- It is linux based Environment that shares lots of resources required to manage UR Complex Apps. It is primarily used for Distributed Computing Applications where the K8s abstract the underlying hardware resources and offers std and consistant UI that one can monitor from a common place. This UI will be used by the Dev Ops Engineer who will be responsible for the maintainence of the Application. The UI looks similar to a Dashboard of JENKINS, where he/she can monitor multiple applications, clusters and allocate the resources required for each of the Applications. The DevOps Engineer also determines the amount of resources that each App may require and allocate the resources accordingly. 

### Issues:
- It needs a heavy infrastructure to showcase the Application. The Complete pipeline is done by a team of testers, DevOps Engineers and QAT teams. Its a collaborative work to make UR services hosted in a K8s server. Its not so user friendly. Ofcourse, there are many UI tools to manage these infrastructure. 
NOTE: https://youtube.com/watch?v=X48VuDVv0do&feature=shares
- U can view this tutorial for further reference. 
