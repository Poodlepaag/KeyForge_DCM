import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Decks from '../views/Decks.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/decks',
    name: 'Decks',
    component: Decks
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
