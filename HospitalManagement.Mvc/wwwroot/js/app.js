import bootstrap from '../../node_modules/bootstrap/dist/js/bootstrap.bundle.js';
globalThis.bootstrap = bootstrap;

import VMasker from '../../node_modules/vanilla-masker/build/vanilla-masker.min.js';
globalThis.VMasker = VMasker;

import { ValidationService } from '../../node_modules/aspnet-validation/dist/aspnet-validation.js';
let v = new ValidationService();
v.bootstrap();