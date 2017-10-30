## Optional Items to start ##
```bash
# images used later
docker pull microsoft/aspnetcore
docker pull microsoft/aspnetcore-build

# samples
docker run hello-world
docker run microsoft/dotnet-samples:dotnetapp
```

## Project Steps ##
```bash
# create a new webapi application
mkdir d101
cd d101
	# see other templates
	dotnet new -l
dotnet new webapi
dotnet run
# Go to: http://localhost:5000/api/values/
# To stop: Ctrl-C
#  ~~ now create new/edit / copy new files in ~~
#  optional steps
	dotnet restore
	dotnet build
dotnet run

docker build -t d101 .
docker run --rm -p 8080:80 d101
docker run -d -p 8080:80 d101

# Go to: http://localhost:8080/api/password
# To stop: Ctrl-C
```

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

# saving and loading images for offline use
# examples
docker save -o aspnetcore.docker microsoft/aspnetcore
docker save -o aspnetcore-build.docker microsoft/aspnetcore-build

docker load -i aspnetcore-build.docker
docker load -i aspnetcore.docker
```
