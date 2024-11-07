<template>
  <div id="carouselExample" class="carousel slide carousel-fade" data-bs-ride="carousel">
    <div class="carousel-indicators">
      <button type="button" data-bs-target="#carouselExample" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
      <button type="button" data-bs-target="#carouselExample" data-bs-slide-to="1" aria-label="Slide 2"></button>
      <button type="button" data-bs-target="#carouselExample" data-bs-slide-to="2" aria-label="Slide 3"></button>
    </div>
    <div class="carousel-inner">
      <!-- Slide 1 -->
      <div class="carousel-item slide-1 active">
        <div class="carousel-content">
          <img src="../assets/images/bg_1.png" class="pizza-image" alt="Pizza">
          <h4>Delicious</h4>
          <h1>ITALIAN CUISINE</h1>
          <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
          <div class="carousel-buttons">
            <button class="btn btn-order">Order Now</button>
            <button class="btn btn-view">View Menu</button>
          </div>
        </div>
      </div>
      <!-- Slide 2 -->
      <div class="carousel-item slide-2">
        <div class="carousel-content">
          <img src="../assets/images/bg_2.png" class="pizza-image" alt="Pizza Slice">
          <h4>Crunchy</h4>
          <h1>ITALIAN PIZZA</h1>
          <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
          <div class="carousel-buttons">
            <button class="btn btn-order">Order Now</button>
            <button class="btn btn-view">View Menu</button>
          </div>
        </div>
      </div>
      <!-- Slide 3 -->
      <div class="carousel-item slide-3">
        <div class="carousel-content">
          <h4>Welcome</h4>
          <h1>WE COOKED YOUR DESIRED PIZZA RECIPE</h1>
          <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
          <div class="carousel-buttons">
            <button class="btn btn-order">Order Now</button>
            <button class="btn btn-view">View Menu</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Carousel',
};
</script>

<style scoped>
  .carousel-item {
    height: 100vh;
    background-size: cover;
    background-position: center;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    text-align: center;
  }

  .slide-1 {
    background-image: url('../assets/images/bg_1.jpg');
  }

  .slide-2 {
    background-image: url('../assets/images/bg_1.jpg');
  }

  .slide-3 {
    background-image: url('../assets/images/bg_3.jpg');
  }

  .carousel-content {
    max-width: 600px;
  }

  .carousel-item h1 {
    font-size: 3rem;
    font-weight: bold;
    text-transform: uppercase;
  }

  .carousel-item h4 {
    font-style: italic;
    font-size: 1.5rem;
    color: #d7a86e;
  }

  .carousel-item p {
    font-size: 1rem;
    margin: 1rem 0;
  }

  .pizza-image {
    width: 200px;
    height: auto;
    margin-bottom: 1rem;
  }

  .carousel-buttons {
    display: flex;
    gap: 1rem;
    justify-content: center;
  }

    .carousel-buttons .btn-order {
      background-color: #ffc107;
      color: #000;
      border: none;
    }

    .carousel-buttons .btn-view {
      background-color: transparent;
      border: 1px solid white;
      color: white;
    }

  .carousel-indicators [data-bs-target] {
    background-color: #fff;
  }
</style>
