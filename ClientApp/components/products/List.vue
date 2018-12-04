<template>
    <div class="products">
        <h1>Products</h1>
        <div class="products_list">
            <div class="products_item" v-for="product in products"
                 :key="product.name">
                <h3 @click="select(product)">{{product.name}}</h3>
                <img :src="product.imgsrc" :alt="product.name"
                     @click="select(product)" />
                <p @click="select(product)">{{product.description}}</p>
                <p @click="select(product)">{{product.price}}</p>
            </div>
        </div>
    </div>
</template>
<script>
  export default {
    name: 'product-list',
    data()  {
        return {
            products:[],
            selectedProduct:null
        };
        },
        mounted() {
            fetch('/api/products')
                .then(response => {
                    return response.json()
                })
                .then(data => {
                    this.products = data
                });
        },
        methods: {
            select(product) {
                this.selectedProduct = product;
            }
        }
};
</script>