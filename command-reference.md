## Optional Items to start ##
```bash
# images used later
docker pull microsoft/aspnetcore:2.0.0
docker pull microsoft/aspnetcore-build:2.0.2

# other samples
docker run hello-world
docker run microsoft/dotnet-samples:dotnetapp
```

## Project Steps ##
```bash
# if you have git installed and are comfortable using it
# download this project (creates a directory named dotnetcore-docker-intro)
git clone https://github.com/brianmwhite/dotnetcore-docker-intro

# if you don't have git, download from here and unzip/copy to a convenient directory
https://github.com/brianmwhite/dotnetcore-docker-intro/archive/master.zip

# go to the newly created directory
cd dotnetcore-docker-intro/

# easily open a finder window
open .

cd ..

# create a new webapi application
mkdir d101
cd d101
	# see other templates
	dotnet new -l
dotnet new webapi
dotnet run
# Go to: http://localhost:5000/api/values/
# To stop: Ctrl-C

# open a finder window
open .
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
docker save -o aspnetcore.docker microsoft/aspnetcore:2.0.0; docker save -o aspnetcore-build.docker microsoft/aspnetcore-build:2.0.2

docker load -i aspnetcore-build.docker
docker load -i aspnetcore.docker
```
