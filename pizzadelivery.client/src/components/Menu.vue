<template>
  <Navbar />

  <div class="menu">
    <h1>Pizza Menu</h1>

    <div v-if="loading" class="loading">Loading...</div>

    <div v-else-if="error" class="error">
      There was an error loading the pizzas: {{ error }}
    </div>

    <div v-else>
      <div v-for="pizza in pizzas" :key="pizza.name" class="pizza-item">
        <img :src="pizza.image_url" :alt="pizza.name" class="pizza-image" />

        <div class="pizza-details">
          <h2>{{ pizza.name }}</h2>
          <p>{{ pizza.description }}</p>
          <p><strong>Price:</strong> ${{ pizza.price }}</p>
          <p><strong>Category:</strong> {{ pizza.category }}</p>
          <p><strong>Size:</strong> {{ pizza.size }}</p>
        </div>
      </div>
    </div>
  </div>

  <Footer />
</template>

<script>
  import axios from "axios";
  import Navbar from './Navbar.vue';
  import Footer from './Footer.vue';

  export default {
    name: "Menu",
    components: {
      Navbar,
      Footer
    },
    data() {
      return {
        pizzas: [],
        loading: true,
        error: null,
      };
    },
    mounted() {
      this.fetchPizzas();
    },
    methods: {
      async fetchPizzas() {
        try {
          const response = await axios.get("https://localhost:7165/api/Pizza");
          this.pizzas = response.data;
          console.log(this.pizzas);
        } catch (err) {
          this.error = err.message;
        } finally {
          this.loading = false;
        }
      },
    },
  };
</script>

<style scoped>
  .menu {
    text-align: center;
    padding: 20px;
  }

  .pizza-item {
    display: flex;
    align-items: center;
    justify-content: center;
    margin: 20px 0;
    padding: 10px;
    border: 1px solid #ddd;
    border-radius: 8px;
  }

  .pizza-image {
    width: 150px;
    height: 150px;
    object-fit: cover;
    margin-right: 20px;
  }

  .pizza-details {
    text-align: left;
    max-width: 400px;
  }

  .loading {
    font-size: 1.5em;
    color: #777;
  }

  .error {
    color: red;
    font-size: 1.2em;
  }
</style>
