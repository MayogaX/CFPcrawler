*****CFPcrawler*****

CREATED BY: Priscila Mayumi Sato (a.k.a. MayogaX) from Brazil
			e-mail: mayumisatox@gmail
			twitter: @MayogaX
CREATED AT THE DATE: July 5th of 2012
CREATED USING: Visual Studio 2010 Ultimate, 
			   C# 4.0, 
			   Asp.Net MVC 4 Web Api
			   Windows Azure toolkit
CREATED FOR TO RUN IN: Windows Azure
PROJECT HOME PAGE: http://lab.mayogax.me/cfpcrawler (under construction)

***RESUME***
~>version: initial commit, using only Twitter Search API
~>objectives: this is a simple crawler that will to use APIs for searsh about
'Call for Papers' of tecnology fairs
~>the relatives datas is take in a XML file
~>return of that app will to be in a XML or JSON (for now)

***URI architecture***
~>For now only GET requests;
~>The format of URI is:
	-By countries:
		http://localhost/cfpcrwaler/<country>.<format>
		http://localhost/cfpcrwaler/<country>?format=<format>
	-By data:
		httP://localhost/cfpcrwaler/<year>.<format>
		httP://localhost/cfpcrwaler/<year>?format=<format>
		httP://localhost/cfpcrwaler/<year>/<month>.<format>
		httP://localhost/cfpcrwaler/<year>/<month>?format=<format>
		httP://localhost/cfpcrwaler/<year>/<month>/<day>.<format>
		httP://localhost/cfpcrwaler/<year>/<month>/<day>?format=.<format>

***TO DO***
~>To use the anothers searsh APIs
~>To add another return formats
~>To redifine the poor architecture
~>To make a good documentation
~>To start to use a nosql database