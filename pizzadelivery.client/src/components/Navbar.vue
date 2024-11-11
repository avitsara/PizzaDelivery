<template>
  <nav class="navbar navbar-expand-lg navbar-dark ftco_navbar bg-dark ftco-navbar-light" id="ftco-navbar">
    <div class="container">
      <a class="navbar-brand" href="index.html">
        <span class="flaticon-pizza-1 mr-1"></span>Pizza<br><small>Delicious</small>
      </a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#ftco-nav" aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
        <span class="oi oi-menu"></span> Menu
      </button>
      <div class="collapse navbar-collapse" id="ftco-nav">
        <ul class="navbar-nav ml-auto">
          <li class="nav-item active"><a href="index.html" class="nav-link">Home</a></li>
          <li class="nav-item active"> <router-link to="/menu" class="nav-link">Menu</router-link></li>
<li class="nav-item"><a href="services.html" class="nav-link">Services</a></li>
          <li class="nav-item"><a href="blog.html" class="nav-link">Blog</a></li>
          <li class="nav-item"><a href="about.html" class="nav-link">About</a></li>
          <li class="nav-item"><a href="contact.html" class="nav-link">Contact</a></li>
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              <img :src="user.avatar" class="rounded-circle" alt="User Avatar" width="30" height="30">
              {{ user.name }}
            </a>
            <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="navbarDropdown">
              <li><a class="dropdown-item" href="#" @click="logout">Logout</a></li>
            </ul>
          </li>
        </ul>
      </div>
    </div>
  </nav>
</template>

<script>
  import { ref, onMounted } from 'vue';
  import axios from 'axios';

  export default {
    name: 'Navbar',
    setup() {
      const user = ref({
        name: '', 
        avatar: 'https://i.pravatar.cc/300' 
      });

      const fetchUsername = () => {
        const storedUsername = localStorage.getItem('username');
        if (storedUsername) {
          user.value.name = storedUsername;
        }
      };

      const logout = async () => {
        try {
          await axios.post('/api/logout'); 
          localStorage.removeItem('token');
          localStorage.removeItem('username');
          window.location.href = '/login';
        } catch (error) {
          console.error('Logout failed', error);
        }
      };

      onMounted(fetchUsername);

      return {
        user,
        logout
      };
    }
  };
</script>

<style scoped>
  .navbar-brand .flaticon-pizza-1 {
    margin-right: 1rem;
  }

  .nav-item.dropdown .nav-link img {
    margin-right: 0.5rem;
  }
</style>
