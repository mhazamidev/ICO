const tofee = artifacts.require("TofeeToken");
const ico = artifacts.require("ICO");
const admin = '0x31E558C846DF799B02BD0eDa90401De966F72f70';

module.exports = async function (deployer) {
  await deployer.deploy(tofee, 100000000);
  const token = await tofee.deployed();
  await deployer.deploy(ico, token.address, admin);
};
