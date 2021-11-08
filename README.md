# slack-attendance-bot
Code for the Beckman Cubesat attendance server.

To run this on linux:
1. Install npm (node.js package manager) [curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.35.3/install.sh | bash]
2. Install node.js version 16.13.0 LTS [nvm install 16.13.0]
3. Run dependencies.sh
4. Configure start.sh to run on system start
5. Point slackbot in slack settings to "your public ip":8000 (https://whatismyipaddress.com/)

Also: Ensure port 8000 is forwarded on the server's network (https://portforward.com/)
