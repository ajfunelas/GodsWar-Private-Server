GodsWar Private Server (War of Gods)
============

Welcome!

Here you will find the incompleted source for the building of what it could potentially be the first GodsWar Private Server! If you are a Developer and you're Eager to continue this project! feel free to grab a fork and eat it!

This version were at real early stages this are the features:

* Network Handling
* Basic Multi-threaded Login Server
* General Programming Aid Utilities
* MySQL DB Support

And other stuff that I'm probably forgetting now :D anyways feel free to check the source!

Thanks!


========================================================
Random Guide I found
Guide:First of all Install Python 2.5
1. download and install MySQL 5.1
2. download and install navicat
3. when all done make sure the username in MySQL is root and pw is what you want it to be
4. create a connection in navicat called Godswar
5. create a database called accounts and godswar
6. put in the 2 SQL i said in the right place
7. extract the server files some where
8. go into gameserver+login server+ db server config.ini change ip's and password to yours ( and user name if u changed it when installing MySQL)
9. now run Login, DB then game server .exe in that order
10. now log in ID:updays pw:updays



Index

* 1) Files to download.
* 2) Installing and Configuring the server files.
* 3) Troubleshooting errors.



====================================================================================

Files to Download

* LoginServer 2.0
* GameServer 1.9 or 2.0
* DBServer 2.0
* MySQL
* Python 2.5




====================================================================================
Installing and Configuring the server files.

First you must install:

* MySQL
* Python 2.5



After you finish installing them download the databases:

To install them follow the guide by ITS-HEAL-

After you are done installing download my loginserver 2.0 /dbserver 2.0 /gameserver (1.9 or 2.0) and extract them.Open the loginserver folder, you will see the config.ini file, open it heres hows it looks like;
Quote
[System]
IP=127.0.0.1
ListenPort=5999
MaxOnline=20
Version=101300

[Database]
DBServer=127.0.0.1
LoginName=YOUR_MYSQL_ADMINISTRATORS_USERNAME
Password=YOUR_MYSQL_ADMINISTRATORS_PASSWORD
DBName=accounts


Quote
If you dont know what is your IPv4 adres , goto start->cmd type ipconfig , scroll up and you will see it should look like this 192.168.1.101


After you are done with login server's config.ini do the same with all others

GameServer
Quote
[LoginServer]
Port=5999
IP=127.0.0.1

[System]
ID=0
IP=127.0.0.1
ListenPort=6001
ServerName=Virgo
MaxOnline=20

[Database]
DBServer=127.0.0.1
LoginName=YOUR_MYSQL_ADMINISTRATORS_USERNAME
Password=YOUR_MYSQL_ADMINISTRATORS_PASSWORD
DBName=godswar

[DBServer]
IP=127.0.0.1
Port=5000

[Note]
Hint=Welcome to the Battle of the Gods!
World1=Test this point, thank you for your participation!
World=Servers will down for maintenance, please visit later!
Player=On-line once you have drained away again!
Name=Test Name





DBServerQuote
[System]
IP=127.0.0.1
ListenPort=5000
MaxOnline=20


[Database]
DBServer=127.0.0.1
LoginName=YOUR_MYSQL_ADMINISTRATORS_USERNAME
Password=YOUR_MYSQL_ADMINISTRATORS_PASSWORD
DBName=godswar



Now open them!If they work, open your client, edit the servers ip to your ip and have fun!

====================================================================================
Troubleshooting errors.

Most common errors :

The Application cannot be started ..... reinstalling the application might fix the problem.
FIX: This means that your computer is outdated subsequently you dont have 2005 redist installed on your machine. Here's where to download them : Click Here!
Resized to 63% (was 1000 x 484) - Click image to enlarge

I get a DBTool error!!!!
FIX: This usually means that either mysql is not started (check the taskmanager to see if its running) or you misconfigured the DBServer!

I get a "IF_NOT: P_res" error!!!!
FIX: This usually means that either mysql is not started or you did something wrong then importing the SQLs
Resized to 71% (was 887 x 440) - Click image to enlarge
