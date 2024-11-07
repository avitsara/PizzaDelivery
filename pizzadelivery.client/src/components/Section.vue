<!--

  <template>
  <section class="home-slider" v-if="mounted">
    <Carousel :items-to-show="1"
              :pagination-enabled="true"
              :navigation-enabled="true"
              :autoplay="autoplay"
      :wrap-around="true"
      class="carousel-wrapper"
    >
      <Slide v-for="(slide, index) in slides" :key="index">
        <div class="slider-item" :style="{ backgroundImage: `url(${getImageUrl(slide.bgImage)})` }">
          <div class="overlay"></div>
          <div class="container">
            <div class="row slider-text align-items-center">
              <div class="col-md-6 col-sm-12 ftco-animate">
                <span class="subheading">{{ slide.subheading }}</span>
                <h1 class="mb-4">{{ slide.title }}</h1>
                <p class="mb-4 mb-md-5">{{ slide.description }}</p>
                <p>
                  <a href="#" class="btn btn-primary p-3 px-xl-4 py-xl-3">Order Now</a>
                  <a href="#" class="btn btn-white btn-outline-white p-3 px-xl-4 py-xl-3">View Menu</a>
                </p>
              </div>
              <div class="col-md-6 ftco-animate">
                <img :src="getImageUrl(slide.image)" class="img-fluid" :alt="slide.alt">
              </div>
            </div>
          </div>
        </div>
      </Slide>
    </Carousel>
  </section>
</template>
-->
<template>
  <div id="carouselExample" class="carousel slide" data-bs-ride="carousel">
    <div class="carousel-inner">
      <div class="carousel-item active slide1">
        <div class="overlay"></div>
        <div class="content">
          <h2><span class="highlight">Delicious</span> ITALIAN CUISINE</h2>
          <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
          <div class="buttons">
            <button class="btn btn-primary">Order Now</button>
            <button class="btn btn-outline-primary">View Menu</button>
          </div>
        </div>
      </div>

      <div class="carousel-item slide2">
        <div class="overlay"></div>
        <div class="content">
          <h2><span class="highlight">Crunchy</span> ITALIAN PIZZA</h2>
          <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
          <div class="buttons">
            <button class="btn btn-primary">Order Now</button>
            <button class="btn btn-outline-primary">View Menu</button>
          </div>
        </div>
      </div>

      <div class="carousel-item slide3">
        <div class="overlay"></div>
        <div class="content">
          <h2><span class="highlight">Welcome</span> WE COOKED YOUR DESIRED PIZZA RECIPE</h2>
          <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
          <div class="buttons">
            <button class="btn btn-primary">Order Now</button>
            <button class="btn btn-outline-primary">View Menu</button>
          </div>
        </div>
      </div>
    </div>

    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
      <span class="carousel-control-prev-icon" aria-hidden="true"></span>
      <span class="visually-hidden">Previous</span>
    </button>
    <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
      <span class="carousel-control-next-icon" aria-hidden="true"></span>
      <span class="visually-hidden">Next</span>
    </button>
  </div>
</template>
<script>
 /* import { Carousel, Slide } from 'vue3-carousel';
  import 'vue3-carousel/dist/carousel.css';

  export default {
    name: 'Section',
    components: {
      Carousel,
      Slide
    },
    data() {
      return {
        mounted: false,
        autoplay: true,
        slides: [
          {
            bgImage: 'bg_1.jpg',
            image: 'bg_1.png',
            subheading: 'Delicious',
            title: 'Italian Cuisine',
            description: 'A small river named Duden flows by their place and supplies it with the necessary regelialia.',
            alt: 'Italian Cuisine Image'
          },
          {
            bgImage: 'bg_2.jpg',
            image: 'bg_2.png',
            subheading: 'Crunchy',
            title: 'Italian Pizza',
            description: 'A small river named Duden flows by their place and supplies it with the necessary regelialia.',
            alt: 'Italian Pizza Image'
          },
          {
            bgImage: 'bg_3.jpg',
            image: 'bg_3.png',
            subheading: 'Welcome',
            title: 'We cooked your desired Pizza Recipe',
            description: 'A small river named Duden flows by their place and supplies it with the necessary regelialia.',
            alt: 'Pizza Recipe Image'
          }
        ]
      };
    },
    computed: {
      carouselTimeout() {
        return 60000;
      }
    },
    mounted() {
      this.mounted = true;
    },
    methods: {
      getImageUrl(image) {
        return new URL(`../assets/images/${image}`, import.meta.url).href;
      }
    }
  };*/

  export default {
    name: 'Section',
  }
</script>


<style scoped>
  /*
.home-slider {
    position: relative;
  }


  .slider-item {
    height: 100vh;
    background-size: cover;
    background-position: center;
    position: relative;
  }

  .overlay {
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: rgba(0, 0, 0, 0.3);
  }

  .carousel-wrapper {
    max-width: 100%;
  }

  .slider-text {
    color: #fff;
  }

  .ftco-animate {
    transition: opacity 1s ease-in-out, transform 1s ease-in-out; 
  opacity: 0;
  }

  .ftco-animate.active {
    opacity: 1;
    transform: translateY(0);
  }

  .subheading, .mb-4, .btn {
    transition: opacity 1s ease-in-out, transform 1s ease-in-out;
  }

  .btn-primary {
    background-color: #e43f5a;
    border: none;
  }

  .btn-white {
    color: #fff;
    border: 1px solid #fff;
  }

  .btn-outline-white {
    background: transparent;
    color: #fff;
  }*/


  #carouselExample {
    position: relative;
  }

  .carousel-item {
    height: 100vh;
    color: #fff;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: left;
    position: relative;
  }

    .carousel-item .overlay {
      position: absolute;
      top: 0;
      left: 0;
      right: 0;
      bottom: 0;
      background: rgba(0, 0, 0, 0.3);
    }

  .slide1 {
    background-image: url('../assets/images/bg_1.jpg');
    background-size: cover;
    background-position: center;
  }

  .slide2 {
    background-image: url('../assets/images/bg_2.jpg');
    background-size: cover;
    background-position: center;
  }

  .slide3 {
    background-image: url('../assets/images/bg_3.jpg');
    background-size: cover;
    background-position: center;
  }

  .content {
    position: relative;
    z-index: 2;
    max-width: 600px;
  }

    .content h2 {
      font-size: 2.5rem;
      line-height: 1.2;
      color: #fff;
    }

    .content .highlight {
      color: #d4a373;
      font-style: italic;
    }

    .content p {
      color: #dcdcdc;
      margin: 1rem 0;
    }

  .buttons {
    display: flex;
    gap: 1rem;
  }

    .buttons .btn-primary {
      background-color: #f5a623;
      border-color: #f5a623;
      color: #fff;
    }

    .buttons .btn-outline-primary {
      border-color: #f5a623;
      color: #f5a623;
    }

  
</style>
