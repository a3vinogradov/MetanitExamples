#!/bin/bash
echo "starting http server on port 9999" &
#python -m SimpleHTTPServer 9999
python -m http.server 9999