# 1. Install
- Node `https://nodejs.org/en/download`
- Angular `https://angular.io/guide/setup-local`

# 2. Run And Deploy
- Configure
  - Go to `https://ionicframework.com/docs/deployment/desktop-app`
  - Go to `https://github.com/electron/electron-packager`
  - Run `npm install -g @ionic/cli`  
  - Run `npm install electron-packager --save-dev` and `npm install electron-packager -g`
  - install [macOS] `brew install homebrew/cask-versions/wine-devel`
  - build for windows `electron-packager ./electron ProductionApp --all --out=.deploy`
- Run `./.build_prod.sh` for prod builds or `./.build_debug.sh` for dev. builds
- App [mac/win] are created in `./electron/.deploy` folder
