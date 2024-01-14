# Git Basics:
### What is Git?
- Git is  popular Version Control System(VCS). Developed by Linus Torvalds(Creator of Linux Kernel). Is currently maintained by Junio Hamano. It is mainly used for tracking code changes, who has made the changes and Code Collaboration. 
- Git helps in managing th projects using a concept called Repositories(Repos). One can clone(make a copy) of the project on any machine where U wish to use it. U can control and track the changes with a concept called STAGING and COMMITING. 
- U can also create BRANCH to allow collaborative work to happen and MERGE th code to allow for work on different parts and versions of the Project. 
- It allows to PULL the latest version of the project to your local system.
- It also allows to PUSH the code created by you into the main or remote location. 
### What you can do with Git?
- Initialize the Git on a folder which is called as Repository.
    - Folder that U created is called as WORKING DIRECTORY (WD) and GIT Intialization is called the GIT REPO. 
- Add the files or create new code/files into WORKING DIRECTORY.
- If U want the git to keep track of those files, U should stage them. 
- After this, U shall commit the files into the Git Repo. 
- When U do this, git keeps track of the changes that U make to those files in UR Working Directory. 
- If U want to store these Git Repo into a central Repository Database, U can use tools like GitHub(MS), GitLab and BitBucket. 
### Why Git?
- It is widely used among the Developer Community.(70% of the developers). 
- Developers can work from any where together. 
- They can track the full history of the project. They can also revert to the previous versions of the project. 
### What is Github?
- Github is a software GUI for managing Git at a centralization location instead of your local machines. 
- Github is a MS product (2018) for managing Git Services remotely. 
- Github is the largest host of source code in the world.
### How to install Git?
- U can download git from the website: https://git-scm.com/download/win.
- It provides 2 ways to work with git: GUI and BASH(Command line UI).
- It allows the user to open the git bash from the folder location itself. 
- Once U create the folder(WD), U can intialize the git repo and start working with it. 
### Creating Repos
- Create a new folder where U wish to work. This folder is called as WD.
- We shall make git to keep track of the files in this folder by initializing the Git. 
- Add Files and code if required to it.  
- U shall check the status of the repostory using git status 
- for the files to add, U should first stage them. 
- Staging is a environment that makes git track your file for any changes U make to it. 
- U commit(updating) the added files into the git, there by making it available as a version. 
- Any commit will create a new version of the files. 
- log command will keep track of the commits U have made with the recent one on the top. 
- U can use options to directly commit to the git without staging it. 
- We can use diff to find the differences in the code. 
- To remove files from the git repo, we can use rm command with a mandatory option --cached. 
### Important Commands
```
git init
git status
git add files seperated by space
git add .
git commit -m "message to store"
git commit -a -m "Commit without staging"
git log 
git diff
git rm --cached filename
```
### Cloning Remote location
- U can get the copy of any public repository available remotely with tools like Github, Gitlab and BitBucket. 
- git clone url_of_the_Repo
- U can make changes to it. 
- U can push the updated code back.
### Pushing local Repo to Remote
- Follow the steps for adding the local repo into Remote location
    - Add git init to it.
    - Commit all the code to the local git
    - run the below commands:
  ```
  git remote add origin <path of the url>
  git branch -M main
  git push -u origin main
  ```        
### Branches
- Branches help in colaborating the code. Assume that U want to develop certain feature which is on experimental use case. U should create a branch of the main and work on the feature branch
- U can push the code into the feature branch, then allowing the main to make a pull request.
- Once the code is approved/accepted, U can merge the branch into main.
- Optionally U can delete the branch after the merging is complete.
  ```
  git checkout b featureBr
  git add newFiles
  git commit -m "adding to branc"
  git push -u origin featureBr
  ```
