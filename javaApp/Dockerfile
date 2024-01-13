# Docker file is a text based file that contains the instructions for the docker to create the image and do the building process to generate a container and execute it.

FROM openjdk:11
WORKDIR /var/www/java
COPY . /var/www/java/
RUN javac samplefile.java
CMD exec java samplefile