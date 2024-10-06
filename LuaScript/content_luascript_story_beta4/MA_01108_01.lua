-- このluaスクリプトは、MA_01108_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
load_image("MA011080101", "content_still_10101011_image", "101010110_StillImage")
load_image("MA011080102", "content_still_10101011_image", "101010111_StillImage")
load_image("MA011080103", "content_still_10101011_image", "101010112_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_TextOnly()
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01108_011001")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01108_011003")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01108_011004")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01108_011005")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01108_011006")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6)
wait_time(1.2)
show_image("MA011080101", 0.0, 0.0, 0,true,false)
fadein(1.6)
wait_time(2.8)
-- ▲直接出力

	--★★ノワール★★:父さんと同じのがいい！
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010003")


	--★★セレスティ★★:そっくりに<br>仕立ててあげるからね
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010004")


	--★★ノワール★★:そっくりなのじゃヤだ！<br>同じのがいい！父さんのヤツが欲しい！！
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010005")


	--★★セレスティ★★:ふたり揃って羽織るところが見たいの
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010006")


	--★★セレスティ★★:だからこうして<br>ノワールのぶんを新しく縫ってるの
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010007")


	--★★セレスティ★★:お父さんは着古したソレでお出かけしてね
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010008")


	--★★ブルーノ★★:おさがりより<br>あたらしいほうがいいだろ？
	Talk(Actor004,"CHRNAME_BRUNO","simple","N","MA_01108_010009")


	--★★ノワール★★:…だって、父さんみたいになりたいんだもん
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010010")


	--★★ディナタン★★:お、お母さん、私には…？
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","MA_01108_010011")


	--★★セレスティ★★:私とそっくりな髪型を教えてあげるっ
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010012")


	--★★ディナタン★★:そっくりな髪型！？
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","MA_01108_010013")


	--★★ノワール★★:ねえ母さん！<br>コートはちゃんと金色にしてくれよ？
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010014")


	--★★ブルーノ★★:金色は目につくぞ、ノワール<br>戦場で金を纏うなんて冒険的だ
	Talk(Actor004,"CHRNAME_BRUNO","simple","N","MA_01108_010015")


	--★★ブルーノ★★:味方からは妬まれるか期待され…<br>敵からは注目されて狙われる
	Talk(Actor004,"CHRNAME_BRUNO","simple","N","MA_01108_010016")


	--★★ノワール★★:超ヤバいじゃん<br>なんで父さんは金のコート着てるの？
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010017")

-- ▼直接出力
CloseTalkWindow()
hide_image(0.6)
wait_time(0.6)
show_image("MA011080102", 0.0, 0.0, 0.6,true,false)
set_scale_image(1.5,1.5)
wait_time(0.6)
-- ▲直接出力

	--★★ブルーノ★★:強くありたいんだ
	Talk(Actor004,"CHRNAME_BRUNO","simple","N","MA_01108_010018")


	--★★ブルーノ★★:ドン底の評価からのスタートでも<br>下馬評を覆し、つねに上を目指せる
	Talk(Actor004,"CHRNAME_BRUNO","simple","N","MA_01108_010019")


	--★★ブルーノ★★:必ず生きて帰ってくるために<br>格好のつく自分になれるように
	Talk(Actor004,"CHRNAME_BRUNO","simple","N","MA_01108_010020")


	--★★ノワール★★:………よく、わかんないや
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010021")

-- ▼直接出力
CloseTalkWindow()
hide_image(0.6)
wait_time(0.6)
show_image("MA011080103",0.0, 0.0, 0.6,true,false)
set_scale_image(1.5,1.5)
wait_time(0.6)
-- ▲直接出力

	--★★セレスティ★★:ディナタン、貴方は厳しく見てあげるのよ？<br>格好ツケたちの背中を
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010022")


	--★★ディナタン★★:みる…？
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","MA_01108_010023")


	--★★セレスティ★★:そう。がんばりすぎちゃうから
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010024")


	--★★ディナタン★★:…う、ん…っ！
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","MA_01108_010025")


	--★★セレスティ★★:ノワール、ブルーノ<br>貴方たちは自分を大切にすること
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010026")


	--★★セレスティ★★:とくに、その手を
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010027")


	--★★ノワール★★:…手？
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010028")


	--★★セレスティ★★:そうよ。手があれば<br>コートが繕えるでしょう？
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010029")


	--★★セレスティ★★:キズついても、ほつれても
	Talk(Actor003,"NPCNAME_0163","simple","N","MA_01108_010030")

-- ▼直接出力
CloseTalkWindow()
hide_image(1.5)
wait_time(2.5)
-- ▲直接出力

	--★★ノワール★★:…もし、手がなくなっちゃったら？
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_010031")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA011080101", "content_still_10101011_image", "101010110_StillImage")
load_image_preload("MA011080102", "content_still_10101011_image", "101010111_StillImage")
load_image_preload("MA011080103", "content_still_10101011_image", "101010112_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
