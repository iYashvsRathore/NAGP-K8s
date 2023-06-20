# Kubernetes & DevOps Advanced Assignment
This repository contains the solution for the Kubernetes & DevOps Advanced assignment for the NAGP 2023 Technology Band III.

# Getting Started
To deploy the solution, follow these steps:

1. Set up a Kubernetes cluster.
2. Run the GitHub Action to build the Docker image for the API project using the provided Dockerfile and Push the Docker image to *iyashvsrathore* Docker Hub repository.
3. Configure the necessary environment variables and secrets using the provided deployment files (*~/.K8s/Configuration & Secret*).
    1. `$ kubectl apply -f configmap.yaml`
    2. `$ kubectl apply -f secret.yaml`
4. Create the Volumes and Storage using the provided deployment files (*~/.K8s/Volumes*).
    1. `$ kubectl apply -f persistece-volume-claim.yaml`
    2. `$ kubectl apply -f storage-class.yaml`
5. Deploy the microservice and database and their services on the Kubernetes cluster using the provided deployment files (*~/.K8s/Microservice* and *~/.K8s/Database*).
    1. `$ kubectl apply -f api-deployment.yaml`
    2. `$ kubectl apply -f api-service.yaml`
    3. `$ kubectl apply -f database-deployment.yaml`
    4. `$ kubectl apply -f database-service.yaml`
6. Create the Database and Tables in the Database using folowwing commands.\
    
    `SA_PASSWORD=$(kubectl get secret SA_PASSWORD -o jsonpath='{.data.<data-key>}' | base64 --decode)`
   
    `kubectl exec -it <pod-name> -- /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -Q 'CREATE DATABASE [User]'`
   
    `kubectl exec -it <pod-name> -- /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P &SA_PASSWORD -Q 'use [User] CREATE TABLE [Users]
      (
          [Id] INT NOT NULL PRIMARY KEY, 
          [Username] NVARCHAR(50) NULL, 
          [Name] NVARCHAR(100) NULL, 
          [EmailID] NVARCHAR(100) NULL
      )'`
8. Access the API from outside the cluster using the LoadBalancer service.


# Important Resources

## Link for the code repository :
[https://github.com/iYashvsRathore/NAGP-K8s/new/master](https://github.com/iYashvsRathore/NAGP-K8s)

## Docker hub URL for docker images
https://hub.docker.com/repository/docker/iyashvsrathore/nagpkubernetesassignment/general

## Demo Recording Video URL

## Docker File Path
[Docker File](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/NAGPK8s/Dockerfile "~/NAGPK8s/Dockerfilee"): https://github.com/iYashvsRathore/NAGP-K8s/blob/master/NAGPK8s/Dockerfile

## Kubernetes YAML Files

1. [API Deployment](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Microservice/api-deployment.yaml "API Deployment File") File
2. [API Service](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Microservice/api-service.yaml "API Service File") File
3. [Database Deployment](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Database/database-deployment.yaml "Database Deployment 
 File") File
4. [Database Service](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Database/database-service.yaml "Database Service File") File
5. [Persistence Volume Claim](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Volumes/persistece-volume-claim.yaml "Persistence Volume Claim File") File:
6. [Storage Class](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Volumes/storage-class.yaml "Storage Class") File
7. [Config Map](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Configuration%20%26%20Secret/configmap.yaml "Config Map File") File
8. [Secret](https://github.com/iYashvsRathore/NAGP-K8s/blob/master/.K8s/Configuration%20%26%20Secret/secret.yaml "Secret File") File
