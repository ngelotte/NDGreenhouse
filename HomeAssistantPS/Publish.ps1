$slug = 'c6a2317c_netdaemon3_1'        # the slug can be found in the url of the browser when navigating to the NetDaemon addon
$json = '{"addon": "' + $slug + '"}'   
$ip   = "192.168.86.15"                 # adapt to your IP address
$port = 8123                           # change if your use another port

$token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiIzYTFmMmJjNWQ4Y2Q0ZDkwOWMxMDlhNmNmYzZhMzI4ZSIsImlhdCI6MTY4Mjg2ODEzMywiZXhwIjoxOTk4MjI4MTMzfQ.xAZerHWu6-xUoOD18ocEFUgB1Q8WuGDCBVfLCC_-i6U"     # generate one here http://homeassistant.local:8123/profile 

# Point to the HA PowerSHell Module
Unblock-File .\Home-Assistant\Home-Assistant.psd1
Unblock-File .\Home-Assistant\Home-Assistant.psm1
Import-Module .\Home-Assistant

New-HomeAssistantSession -ip  $ip -port $port -token $token

Invoke-HomeAssistantService -service HASSIO.ADDON_STOP -json $json

Remove-Item -Recurse -Force \\homeassistant.local\config\netdaemon3\*
dotnet publish -c Release NDGreenhouse.csproj -o \\homeassistant.local\config\netdaemon3

Invoke-HomeAssistantService -service HASSIO.ADDON_START -json $json