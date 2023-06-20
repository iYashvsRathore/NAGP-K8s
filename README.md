# Kubernetes & DevOps Advanced Assignment
This repository contains the solution for the Kubernetes & DevOps Advanced assignment for the NAGP 2023 Technology Band III.

# Getting Started
To deploy the solution, follow these steps:

1. Set up a Kubernetes cluster.
2. Run the GitHub Action to build the Docker image for the API project using the provided Dockerfile and Push the Docker image to your *iyashvsrathore* Docker Hub repository.
3. Configure the necessary environment variables and secrets using the provided deployment files (*~/.K8s/Configuration & Secret*).
4. Create the Volumes and Storage using the provided deployment files (*~/.K8s/Volumes*).
5. Deploy the microservice and database and their services on the Kubernetes cluster using the provided deployment files (*~/.K8s/Microservice* and *~/.K8s/Database*).
6. Create the Database and Tables in the Database using folowwing commands.
    1. `kubectl exec -it <pod-name> -- /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P '<SA_PASSWORD>' -Q 'CREATE DATABASE [User]'`
    2. `kubectl exec -it <pod-name> -- /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P '<SA_PASSWORD>' -Q 'use [User] CREATE TABLE [Users]
      (
          [Id] INT NOT NULL PRIMARY KEY, 
          [Username] NVARCHAR(50) NULL, 
          [Name] NVARCHAR(100) NULL, 
          [EmailID] NVARCHAR(100) NULL
      )'`
8. Access the API from outside the cluster using the LoadBalancer service.


# Important Resources

## Link for the code repository :
https://github.com/iYashvsRathore/NAGP-K8s/new/master?readme=1

## Docker hub URL for docker images
https://hub.docker.com/repository/docker/iyashvsrathore/nagpkubernetesassignment/general

## Demo Recording Video URL

## Docker File Path
[Docker File](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/NAGPK8s/Dockerfile "~/NAGPK8s/Dockerfilee"): https://github.com/iYashvsRathore/NAGP-K8s/blob/master/NAGPK8s/Dockerfile

## Kubernetes YAML Files

1. [API Deployment](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Microservice/api-deployment.yaml "API Deployment File") File
2. *API Service* File: ~/K8s/Microservice/api-service.yaml
3. *Database Deployment* File: ~/K8s/Database/database-deployment.yaml
4. *Database Service* File: ~/K8s/Database/database-service.yaml
5. *Persistence Volume Claim* File: ~/K8s/Volumes/persistence-volume-claim.yaml
6. *Storage Class* File: ~/K8s/Volumes/storage-class.yaml
7. *Config Map* File: ~/K8s/Configuration & Secret/configmap.yaml
8. *Secret* File: ~/K8s/Configuration & Secret/secret.yaml