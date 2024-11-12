<template>
  <Navbar />

  <div class="menu">
    <h1>Pizza Menu</h1>

    <div v-if="loading" class="loading">Loading...</div>

    <div v-else-if="error" class="error">
      There was an error loading the pizzas: {{ error }}
    </div>

    <div v-else class="pizza-grid">
      <div v-for="pizza in pizzas" :key="pizza.name" class="pizza-card">
        <img :src="pizza.image_url" :alt="pizza.name" class="pizza-image" />

        <div class="pizza-details">
          <h2>{{ pizza.name }}</h2>
          <p>{{ pizza.description }}</p>
          <p><strong>Price:</strong> ${{ pizza.price }}</p>
          <p><strong>Category:</strong> {{ pizza.category }}</p>
          <p><strong>Size:</strong> {{ pizza.size }}</p>
          <button class="order-button">Order Now</button>
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
  }

  .pizza-grid {
    display: flex;
    flex-wrap: wrap;
    gap: 20px;
    justify-content: center;
  }

  .pizza-card {
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 8px;
    overflow: hidden;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    transition: transform 0.3s ease;
  }

    .pizza-card:hover {
      transform: translateY(-5px);
    }

  .pizza-image {
    width: 100%;
    height: 200px;
    object-fit: cover;
  }

  .pizza-details {
    padding: 16px;
  }

  .order-button {
    margin-top: 10px;
    padding: 10px 20px;
    background-color: #ff6347;
    color: #fff;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    transition: background-color 0.3s ease;
  }

    .order-button:hover {
      background-color: #ff4500;
    }
</style>
