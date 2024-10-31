<template>
  <div class="container mt-5">
    <div class="row justify-content-center">
      <div class="col-md-6">
        <h2 class="text-center mb-4">Register</h2>
        <form @submit.prevent="submitForm" novalidate>
          <div class="mb-3">
            <label for="name" class="form-label">Name</label>
            <input type="text"
                   class="form-control"
                   id="name"
                   v-model="formData.name"
                   :class="{ 'is-invalid': errors.name }"
                   required
                   placeholder="Enter your name" />
            <div v-if="errors.name" class="invalid-feedback">
              {{ errors.name }}
            </div>
          </div>
          <div class="mb-3">
            <label for="email" class="form-label">Email</label>
            <input type="email"
                   class="form-control"
                   id="email"
                   v-model="formData.email"
                   :class="{ 'is-invalid': errors.email }"
                   required
                   placeholder="Enter your email" />
            <div v-if="errors.email" class="invalid-feedback">
              {{ errors.email }}
            </div>
          </div>
          <div class="mb-3">
            <label for="password" class="form-label">Password</label>
            <input type="password"
                   class="form-control"
                   id="password"
                   v-model="formData.password"
                   :class="{ 'is-invalid': errors.password }"
                   required
                   placeholder="Enter your password" />
            <div v-if="errors.password" class="invalid-feedback">
              {{ errors.password }}
            </div>
          </div>
          <div class="mb-3">
            <label for="confirmPassword" class="form-label">Confirm Password</label>
            <input type="password"
                   class="form-control"
                   id="confirmPassword"
                   v-model="formData.confirmPassword"
                   :class="{ 'is-invalid': errors.confirmPassword }"
                   required
                   placeholder="Confirm your password" />
            <div v-if="errors.confirmPassword" class="invalid-feedback">
              {{ errors.confirmPassword }}
            </div>
          </div>
          <div class="d-grid gap-2">
            <button type="submit" class="btn btn-primary">Register</button>
          </div>
          <div class="login-link">
            <a href="login">Already have an account? Log in here!</a>
          </div>
        </form>
      </div>
    </div>

  </div>
</template>

<script>
  import { ref } from 'vue';
  import axios from 'axios';
  export default {
    name: 'Register',
    setup() {
      const formData = ref({
        name: '',
        email: '',
        password: '',
      });

      const errors = ref({
        name: '',
        email: '',
        password: '',

      });

      const validateForm = () => {
        errors.value = {
          name: '',
          email: '',
          password: '',
        };

        let valid = true;
        if (!formData.value.name) {
          errors.value.name = 'Name is required';
          valid = false;
        }
        if (!formData.value.email) {
          errors.value.email = 'Email is required';
          valid = false;
        } else if (!/\S+@\S+\.\S+/.test(formData.value.email)) {
          errors.value.email = 'Email is invalid';
          valid = false;
        }
        if (!formData.value.password) {
          errors.value.password = 'Password is required';
          valid = false;
        }
        if (formData.value.password !== formData.value.confirmPassword) {
          errors.value.confirmPassword = 'Passwords do not match';
          valid = false;
        }
        return valid;
      };

      const submitForm = async () => {
        if (validateForm()) {
          try {
            const response = await axios.post('https://localhost:7165/api/User/register', {
              user_name: formData.value.name,
              email: formData.value.email,
              password: formData.value.password
            });
            console.log(response.data);
            console.log('User registered successfully:', response.data);
            this.$router.push('/login');
          } catch (error) {
            console.error('Error registering user:', error);
            console.log(error.response);
          }
        }
      };

      return {
        formData,
        errors,
        submitForm
      };
    }
  };
</script>

<style scoped>
  input {
    width: 500px;
  }
</style>
