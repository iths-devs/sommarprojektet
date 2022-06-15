# Building and running the frontend

## Install Node.js

If you already have Node.js installed, you can skip step 1. If you already have VS Code setup for JavaScript development you can skip step 1 & 2.

1. Go to [this page](https://nodejs.org/en/download/), download and install Node.js.
2. In Visual Studio Code, install the following extensions:
    - ES7 React/Redux/GraphQL/React-Native snippets
    - Prettier – Code formatter
    - ESLint

## Install all required dependencies

Navigate to the `frontend` directory and run:

```bash
npm install
```

## Available Scripts

In the `frontend` directory, you can run:

### `npm start`

Runs the app in the development mode.
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.
You will also see any lint errors in the console.

### `npm run build`

Builds the app for production to the `build` folder.
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `npm run lint`

Checks the code for lint errors according to the [ESLint](.eslintrc.json) configuration.

### `npm run format`

Formats the code according to the [Prettier](.prettierrc) configuration.
