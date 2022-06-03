# OrdersService

Create docker image
===================
docker build -t <image name> -f Dockerfile .
- The . in the docker build command sets the build context of the image
- The -f switch is the path to the Dockerfile
== This command builds the image and creates a local repository named <image name> that points to that image.

Create container
================
docker create --name <container name> <image name>

List all containers: docker ps -a
List active containers: docker ps

Start/Stop/Delete container
=================
docker start <container name>
docker stop <container name>

Remove container - docker rm cont-order-service

Connect to container
===================
docker start <container name>
docker attach --sig-proxy=false <container name>

docker run -p 8003:80 -it --rm order-service

Remove image - docker rmi order-service:latest


docker image tag <source image>[:tag] <target image>[:tag]

docker image push <target image>[:tag]
