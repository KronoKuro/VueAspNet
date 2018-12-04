import Vue from 'vue';
import VueRouter from 'vue-router';
import User from './components/users/User.vue'
import Products from './components/products/List.vue'

Vue.use(VueRouter);
const routes = [
    { path: "/users", component: User },
    { path: "/products", component: Products }
];
new Vue({
el: '#app-root',
router: new VueRouter({ mode: 'history', routes: routes }),
render: h => h(require('./components/App.vue'))
});
