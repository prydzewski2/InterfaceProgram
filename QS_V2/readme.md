# 1. Install
- Node `https://nodejs.org/en/download`
- Angular `https://angular.io/guide/setup-local`

# 2. Configure [macOS]
- Go to `https://github.com/glegrain/STM32-with-macOS`
- Run steps from 1 to 5
- Start device programmer
  - Run `openocd -f /usr/local/Cellar/open-ocd/0.11.0/share/openocd/scripts/board/stm32l4discovery.cfg`
  
# 3. Run And Deploy
- Configure
  - Go to `https://ionicframework.com/docs/deployment/desktop-app`
  - Go to `https://github.com/electron/electron-packager`
  - Run `npm install -g @ionic/cli`  
  - Run `npm install electron-packager --save-dev` and `npm install electron-packager -g`
  - install [macOS] `brew install homebrew/cask-versions/wine-devel`
  - build for windows `electron-packager ./electron ProductionApp --all --out=.deploy`
- Run `./.build_prod.sh` for prod builds or `./.build_debug.sh` for dev. builds
- App [mac/win] are created in `./electron/.deploy` folder
- Sign in as `336FA706`

# 4. Handle app package change
- run `$(npm bin)/electron-rebuild`

# 5. TODOs
- Remove node_modules from the prod. build
- zip production artifacts and push to the repo
