# CSRFDemo
Demo to show CSRF attack and AntiForgeryToken

# Startup
1. setup db connectionStrings in web.config in victim project and use migration command to update database
![update-database.png](/Readme/update-database.png?raw=true "Update Database")
2. add a different domain binding for victim site in iis express config
![update-iisexpress-config.png](/Readme/update-iisexpress-config.png?raw=true "Update IISExpress Config")
3. add the domain specified in step2 to hosts file
![update-hosts.png](/Readme/update-hosts.png?raw=true "Update Hosts")
