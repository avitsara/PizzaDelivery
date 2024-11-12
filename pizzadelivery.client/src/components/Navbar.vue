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
          <li class="nav-item active"><router-link to="/home" class="nav-link">Home</router-link></li>
          <li class="nav-item active"><router-link to="/menu" class="nav-link">Menu</router-link></li>
          <li class="nav-item"><a href="services.html" class="nav-link">Services</a></li>
          <li class="nav-item"><a href="blog.html" class="nav-link">Blog</a></li>
          <li class="nav-item"><a href="about.html" class="nav-link">About</a></li>
          <li class="nav-item"><a href="contact.html" class="nav-link">Contact</a></li>

          <li class="nav-item">
            <a href="contact.html" class="nav-link">
              <img :src="user.basket" class="icon-color" alt="User basket" width="30" height="30">
            </a>
          </li>

          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              <img :src="user.avatar" class="icon-color" alt="User Avatar" width="30" height="30">
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

  export default {
    name: 'Navbar',
    setup() {
      const user = ref({
        name: '',
        avatar: '/src/assets/images/avatar.png',
        basket: '/src/assets/images/basket.png'
      });

      const fetchUsername = () => {
        const storedUsername = localStorage.getItem('username');
        if (storedUsername) {
          user.value.name = storedUsername;
        }
      };

      const logout = () => {
        localStorage.removeItem('token');
        localStorage.removeItem('username');

        window.location.href = '/login';
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

  .icon-color {
    filter: invert(59%) sepia(66%) saturate(742%) hue-rotate(325deg) brightness(102%) contrast(101%);
  }
</style>
