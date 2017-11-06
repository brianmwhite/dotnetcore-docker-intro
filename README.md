Note: I have several USB flash drives with the installers and images on them. Feel free to borrow one, copy the files to your computer and share with someone else. 

## Downloads ##

To get a head start on things, please download the Docker installer.

- [Docker for Mac](https://store.docker.com/editions/community/docker-ce-desktop-mac)
- [Docker downloads for other platforms](https://www.docker.com/community-edition#/download)

We'll also touch on the .NET Core SDK and Visual Studio Code at the end, but those aren't needed unless you want to create and build your own .NET application from scratch.

- [.NET Core SDK](https://www.microsoft.com/net/core#macos)
- [Visual Studio Code](https://code.visualstudio.com): you can use any text editor but Visual Studio Code provides a nice lightweight IDE including debugging. There are many language plugins - including, Node, Python, etc.

## Working ahead ##

If you are feeling ambitious, continue with the next steps. We'll walk through these in detail during the presentation but they do take some time to download and install. 
- Install Docker (you don't need to create an account for this exercise)
- Once docker is installed and running. Go to the terminal and run the following commands (these download official Microsoft images that are fairly large so it's good to get a head start on them)
```bash
#Note: these are two commands separated by a semi colon, they'll run sequentially
docker pull microsoft/aspnetcore-build:2.0.2; docker pull microsoft/aspnetcore:2.0.0
```

## Walk Through ##

[Command Reference](command-reference.md)
