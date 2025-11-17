# Project Title

Insurance Premium calculation.

## Description

Created project with clean architecture and added service DI then Test and related calculation, Database design.

## Developer Notes:
 * Initial Setup 
 * Clean setup as per need 
 * Serrvice Interface added
 * View added with event trigger for calculation
 * writing Test cases for the service

### Download Path

* git clone https://github.com/WebsterSharad/InsurancePremiumCalc



### Project Structure

 * InsurancePremiumCalc.Domain -> Entity(Db Table- if using EF Core)
 * InsurancePremiumCalc.Application -> Interfaces,Services
 * InsurancePremiumCalc.Infrastructure -> Api, Repository,context,DBacess
 * InsurancePremiumCalc.Presentation -> Mvc application for presentation

### Project Overview

* This is a InsurancePremiumCalc project having calculations of Insurance Premium Calculation. 

 * InsurancePremiumCalc.Domain>>Model>> having DB structure in text file only
 * InsurancePremiumCalc.Presentation >> used MVC application and used js html as mentioned
 * InsurancePremiumCalc.Infrastructure>> added but as not using DB server and dbcontext and migration It is added as using clean architecture.                                           
 * InsurancePremiumCalc.Test>> Adding for test






