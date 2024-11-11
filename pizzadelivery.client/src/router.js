import { createRouter, createWebHistory } from 'vue-router';
import Register from './components/Register.vue';
import Login from './components/Login.vue';
import Home from './components/Home.vue';
import Menu from './components/Menu.vue';
const routes = [
  { path: '/', component: Register },
  { path: '/login', component: Login },
  { path: '/home', component: Home },
  { path: '/menu', component: Menu }

];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;
