## Downloads

- [Docker Community Edition Downloads](https://www.docker.com/community-edition#/download)
- [.NET Core SDK](https://www.microsoft.com/net/download/)

Optional
- [Visual Studio Code](https://code.visualstudio.com): you can use any text editor but Visual Studio Code provides a nice lightweight IDE including debugging. There are many language plugins - including, Node, Python, etc.
- [Postman](https://www.getpostman.com/apps): a tool to query web services and inspect the results

## Prerequisites

- Install Docker (you don't need to create an account)
- Install the .NET Core SDK
- (Optionally) Install Visual Studio Code

## Walk Through
### Create A .NET Core Web Services Project (using .NET SDK) 

* first create a new directory
```bash
mkdir d101
cd d101
```
* to see other templates that are provided out of the box
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
-- you can also use dotnet restore (to get dependencies) and dotnet build (to build the project). the run command does both of those as well.
```
* Go to: http://localhost:5000/api/values/
* To stop: Ctrl-C

### Docker
* Create the Dockerfile, you can use the one located [here](https://github.com/brianmwhite/dotnetcore-docker-intro/blob/master/Dockerfile)
* Place it in the root of the d101 folder

* Build the docker image
```bash
docker build -t d101 .
```
* Run the docker image
```bash
# --rm (run, press Ctrl-C to stop, the container automatically gets removed) or -d (run in the background)
docker run --rm -p 8080:80 d101
```

### Using a browser or a tool like Postman
* Go to: http://localhost:8080/api/values/
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

# see actual sizes of docker images
docker system df -v
```
