-- このluaスクリプトは、MA_01B900_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
load_image("103030040", "content_still_10303004_image", "103030040_StillImage")
load_image("103010190", "content_still_10301019_image", "103010190_StillImage")
load_image("103030050", "content_still_10303005_image", "103030050_StillImage")
load_image("103010010", "content_still_10301001_image", "103010010_StillImage")
se_play("SE_ADV_MA_01B900_17_DeepWater_loop")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101010","001","101010001")
	Actor002 = InitializeCharacter_2DOnly("101009","005","101009005")
	Actor003 = InitializeCharacter_2DOnly("101012","004","101012004")
	Actor004 = InitializeCharacter_2DOnly("101021","003","101021003")
	Actor005 = InitializeCharacter_2DOnly("101010","003","101010003")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ランスロット★★:なにが本物かわからないまま
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_200002")


	--★★ランスロット★★:逃げ足だけで<br>俺は生きてきたんだよ
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_200003")


	--★★ランスロット★★:ノワール、お前に追いかけられるような<br>そんな道を歩んできてはいないんだよ
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_200004")


	--★★ランスロット★★:ノワール。お前に背を押され続けたから<br>俺は前へと走ることが出来たんだよ
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_200005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
show_image("103030040", 0.0, 0.0, 0.0)
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ランスロット★★:産まれて間もなくの頃<br>海の向こうの故国が滅びた
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_210002")


	--★★ランスロット★★:バルバロイによるものだと言われている<br>俺は妖精ニニアンに救われ<ruby=コルベニック>聖杯</ruby>城へと逃げ延びた
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_210003")

	change_face(Actor001,"Sad")

	--★★ランスロット★★:ずっと、親から貰った名を<br>持ち続けることに違和感があった
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_210005")


	--★★ランスロット★★:ずっと、親から貰った命で<br>生き続けることに違和感があった
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_210006")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ランスロット★★:親も故郷も覚えていない<br>この血が繋がる先にはなにもない
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_210007")

	change_face(Actor001,"Sad")

	--★★ランスロット★★:この名も、この命も<br>自分のものではないように感じた
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_210008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_BEFORE)
-- ▲直接出力
-- ▼直接出力
 --エフェクト開始
-- ▲直接出力
-- ▼直接出力
show_image("103010010", 0.0, 0.0, 0.0)
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:ランスロット！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B900_220002")

	change_face(Actor001,"Normal")

	--★★ランスロット★★:<ruby=ガラハッド>本当の名</ruby>から逃げた
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220003")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ランスロット★★:唯一生き延びた俺は家族から遺されたものを<br>継がねばならないはずなのに
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220005")


	--★★ブルーノ★★:ランスロット
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","MA_01B900_220006")


	--★★ランスロット★★:己の命を<br>まっとうすることから逃げた
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220007")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力

	--★★ランスロット★★:誰かの命にぶら下がってなければ<br>俺という存在が確かめられなかった
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220008")

	change_face(Actor003,"Smile")

	--★★ディナタン★★:ランス兄ちゃん！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B900_220010")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:家族が欲しかった<br>疑いようもなく己を肯定してくれる繋がりが
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220011")

	change_face(Actor001,"Normal")

	--★★ランスロット★★:ある時、湖を覗き込んで思った<br>水のようになれないものかと
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220012")


	--★★ランスロット★★:透明で、時には光に照らされ黄金に輝く<br>誰かにとって不可欠な存在に
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220013")


	--★★ランスロット★★:そうすれば本当に<br>自分の道を歩める気がした
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220015")

	change_face(Actor001,"Sad")

	--★★ランスロット★★:いつか「生きていてよかった」と<br>本当に思える気がしたんだ
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_220016")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_BEFORE)
-- ▲直接出力
-- ▼直接出力
 --エフェクト開始
-- ▲直接出力
-- ▼直接出力
show_image("103030050", 0.0, 0.0, 0.0)
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★テロップ★★:「自分で名乗ってしまえ」
	Talk(Actor006,"telop","narration","N","MA_01B900_230002")


	--★★テロップ★★:「俺が逃げ道を塞いでやろう<br>お前は今日から進み続けなきゃならない」
	Talk(Actor006,"telop","narration","N","MA_01B900_230003")


	--★★テロップ★★:「自分で敷いたその道を<br>名前で強いた運命を」
	Talk(Actor006,"telop","narration","N","MA_01B900_230004")


	--★★テロップ★★:「『最強騎士』と名乗りを上げて」
	Talk(Actor006,"telop","narration","N","MA_01B900_230005")


	--★★ランスロット_2★★:最強騎士………
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01B900_230007")


	--★★テロップ★★:「最強騎士に斬られるのなら<br>格好だってつくだろう」
	Talk(Actor006,"telop","narration","N","MA_01B900_230008")

	change_face(Actor005,"Sad")

	--★★ランスロット_2★★:………B級な名前だな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01B900_230010")


	--★★テロップ★★:「王を殺してくれるよな」
	Talk(Actor006,"telop","narration","N","MA_01B900_230011")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_OUT_OUT)
-- ▲直接出力
-- ▼直接出力
 --エフェクト終了
-- ▲直接出力
-- ▼直接出力
hide_image()
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_AFTER)
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力

	--★★ランスロット★★:だというのに<br>俺はまた逃げたんだ。ノワール
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_230013")


	--★★ランスロット★★:最低だと思わないか。ノワール
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01B900_230014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103030040", "content_still_10303004_image", "103030040_StillImage")
load_image_preload("103010190", "content_still_10301019_image", "103010190_StillImage")
load_image_preload("103030050", "content_still_10303005_image", "103030050_StillImage")
load_image_preload("103010010", "content_still_10301001_image", "103010010_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101010","001","101010001")
	InitializeCharacter_2DOnly_Preload("101009","005","101009005")
	InitializeCharacter_2DOnly_Preload("101012","004","101012004")
	InitializeCharacter_2DOnly_Preload("101021","003","101021003")
	InitializeCharacter_2DOnly_Preload("101010","003","101010003")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
