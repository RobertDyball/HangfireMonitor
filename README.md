# HangfireMonitor
ASP.Net Core + Hangfire + SignalR

Wondered how an app would look that ran Hangfire under ASP.Net core, using SignalR to let an Angular front end know when along running job had finished.

ASP.Net Core is currently version 1.1 however SignalR is due in version 1.2, so the code here currently uses early test releases of SignalR and various other ASP.Net components to work.
Hangfire was available already for ASP.Net Core.

Please use at your own risk, however if you'd like to use this, please help yourself.

Clone, build and run, you should see these:

(1) Hangfire dashboard, browse to http://localhost:27882/hangfire/ 
(2) SignalR demos, browse to: http://localhost:27882/

The demos for SignalR are from the samples here: https://github.com/aspnet/SignalR-Server
Hangfire is documented here: http://hangfire.io/

(more to come)