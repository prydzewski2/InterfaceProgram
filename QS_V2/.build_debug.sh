clear;
echo 'App[build] Clean'
rm -rf ./www
echo 'App[build] Build ionic'
npm install
cd ./electron || exit
npm install
# shellcheck disable=SC2046
$(npm bin)/electron-rebuild
cd ..
ionic build
echo 'App[build] Sync electron'
npx cap sync @capacitor-community/electron
echo 'App[build] Serve electron'
npx cap open @capacitor-community/electron
