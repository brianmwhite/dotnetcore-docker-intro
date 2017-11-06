Note: I have several USB flash drives with the installers and images on them. Feel free to borrow one, copy the files to your computer and share with someone else. 

## Downloads

To get a head start on things, please download the Docker installer.

- [Docker for Mac](https://store.docker.com/editions/community/docker-ce-desktop-mac)
- [Docker downloads for other platforms](https://www.docker.com/community-edition#/download)

We'll also touch on the .NET Core SDK and Visual Studio Code at the end, but those aren't needed unless you want to create and build your own .NET application from scratch.

- [.NET Core SDK](https://www.microsoft.com/net/core#macos)
- [Visual Studio Code](https://code.visualstudio.com): you can use any text editor but Visual Studio Code provides a nice lightweight IDE including debugging. There are many language plugins - including, Node, Python, etc.

## Working ahead

If you are feeling ambitious, continue with the next steps. We'll walk through these in detail during the presentation but they do take some time to download and install. 
- Install Docker (you don't need to create an account for this exercise)
- Once docker is installed and running. Go to the terminal and run the following commands (these download official Microsoft images that are fairly large so it's good to get a head start on them)

Note: these are two commands separated by a semi colon, they'll run sequentially
```bash
docker pull microsoft/aspnetcore-build:2.0.2; docker pull microsoft/aspnetcore:2.0.0
```
if you copied files from the USB flash drive
```bash
docker load -i aspnetcore-build.docker
docker load -i aspnetcore.docker
```

## Walk Through
### Clone/Download this repository
* If you have git installed and are comfortable using it, run this command in your terminal to clone the repository to your Documents folder
```bash
cd ~/Documents
git clone https://github.com/brianmwhite/dotnetcore-docker-intro
```
* Alternatively, download the zip file of this repository and copy to your ~/Documents folder (or somewhere else you can navigate to easily)
* [Download Zip](https://github.com/brianmwhite/dotnetcore-docker-intro/archive/master.zip)

### Walk through the files
* Inspect the following files:
  * [PasswordController](https://github.com/brianmwhite/dotnetcore-docker-intro/blob/master/Controllers/PasswordController.cs)
  * [Constants](https://github.com/brianmwhite/dotnetcore-docker-intro/blob/master/Controllers/Constants.cs)
  * [Dockerfile](https://github.com/brianmwhite/dotnetcore-docker-intro/blob/master/Dockerfile)
  * [.dockerignore](https://github.com/brianmwhite/dotnetcore-docker-intro/blob/master/.dockerignore)

### Open up a terminal window and navigate to ~/Documents (where these project files are installed)
```bash
#if you cloned the repo using git
cd ~/Documents/dotnetcore-docker-intro
#or (if you downloaded the zip)
cd ~/Documents/dotnetcore-docker-intro-master
```

### Docker
* Build the docker image
```bash
docker build -t d101 .
```
* Run the docker image
```bash
# --rm (run, press Ctrl-C to stop, the container automatically gets removed) or -d (run in the background)
docker run --rm -p 8080:80 d101
```

### Browse to the password web service method
* Go to: http://localhost:8080/api/password
* To stop: Ctrl-C

## Other Commands ##
```bash
# list all containers
docker ps -a

# list images
docker images

# remove specified container
docker rm <container>

# remove specified image
docker rmi <image>

# remove unused data
docker system prune
```

### Create .NET Core Project (using .NET SDK) 

* create a new webapi application
```bash
mkdir d101
cd d101
```
* see other templates
```bash
dotnet new -l
```
* create a new web api project
```bash
dotnet new webapi
```
* run the project
```bash
dotnet run
```
* Go to: http://localhost:5000/api/values/
* To stop: Ctrl-C
