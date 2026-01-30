using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoApi;
using Xunit;
namespace CryptoApi.Tests
{
    public class EncryptionTests
    {
        //EncryptionTests
        [Fact]
        public void Encrypt_ValidText_ReturnCorrectResult()
        {
            var cipher = new CaesarCipher();
            var result =cipher.Encrypt("abc",3);
            Assert.Equal("def", result);
        }

        [Fact]
        public void Encrypt_InvalidResult_ReturnFalse()
        {
            var cipher = new CaesarCipher();
            var result =cipher.Encrypt("abc",3);
            Assert.NotEqual("xyz", result);
        }
        [Fact]
        public void Decrypt_ValidText_ReturnCorrectResult()
        {
            var cipher = new CaesarCipher();
            var result = cipher.Decrypt("def",3);
            Assert.Equal("abc", result);
        }

        [Fact]
        public void Decrypt_ValidResult_ReturnFalse()
        {
            var cipher = new CaesarCipher();
            var result = cipher.Decrypt("abc", 3);
            Assert.NotEqual("def", result);
        }

    }
    }