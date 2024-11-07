import { createApp } from 'vue';
import App from './App.vue';
import router from './router';

import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import './assets/css/open-iconic-bootstrap.min.css';
import './assets/css/animate.css';
import './assets/css/owl.carousel.min.css';
import './assets/css/owl.theme.default.min.css';
import './assets/css/magnific-popup.css';
import './assets/css/aos.css';
import './assets/css/ionicons.min.css';
import './assets/css/bootstrap-datepicker.css';
import './assets/css/jquery.timepicker.css';
import './assets/css/flaticon.css';
import './assets/css/icomoon.css';
import './assets/css/style.css';
import 'swiper/swiper-bundle.css';
import 'vue-slick-carousel/dist/vue-slick-carousel.css'
import 'vue-slick-carousel/dist/vue-slick-carousel-theme.css'
import 'vue3-carousel/dist/carousel.css';

/*import BootstrapVue3 from 'bootstrap-vue-3';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue-3/dist/bootstrap-vue-3.css';*/

const app = createApp(App);
app.use(router);
//app.use(BootstrapVue3);
app.mount('#app');
