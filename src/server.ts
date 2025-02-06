import 'zone.js/node';
import express from 'express';
import { ngExpressEngine } from '@nguniversal/express-engine';
import { join } from 'path';

import { APP_BASE_HREF } from '@angular/common';
import { existsSync } from 'fs';
import { AppServerModule } from './app/app.server.module';

export function app() {
  const server = express();
  const distFolder = join(process.cwd(), 'dist/metraj-proje-1/browser'); // Burada proje adı (metraj-proje-1) kontrol edin
  const indexHtml = existsSync(join(distFolder, 'index.original.html')) ? 'index.original.html' : 'index.html';

  server.engine('html', ngExpressEngine({
    bootstrap: AppServerModule,
  }));

  server.set('view engine', 'html');
  server.set('views', distFolder);

  server.get('*.*', express.static(distFolder, {
    maxAge: '1y'
  }));

  server.get('*', (req, res) => {
    res.render(indexHtml, { req, providers: [{ provide: APP_BASE_HREF, useValue: req.baseUrl }] });
  });

  return server;
}

function run() {
  const port = process.env.PORT || 4000;

  const server = app();
  server.listen(port, () => {
    console.log(`Node Express server listening on http://localhost:${port}`);
  });
}

if (require.main === module) {
  run();
}

export * from './main.server';
