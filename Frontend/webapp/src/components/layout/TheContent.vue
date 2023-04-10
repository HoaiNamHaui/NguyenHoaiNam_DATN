<template>
    <div class="content">
        <the-home />
    </div>
</template>
<script>
import TheHome from '../views/TheHome.vue';
export default {
  name: 'TheContent',
  components: {
    TheHome
  }
}
</script>

<style scoped>
@import url(../../css/layout/content.css);
</style>