-- このluaスクリプトは、CO_101001_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_004)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false) --自動首振り制御
set_common_look_at(Actor001,Actor002) --キャラクターに向く
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false) --自動首振り制御
set_common_look_at(Actor002,Actor001) --キャラクターに向く
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ティルフィング、ちょっといいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい、マスター<br>いかがなさいましたか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:えっと、別に<br>大したことじゃないんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010004")


	--★★ノワール★★:ティルフィングと<br>ちょっと話したいなと思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010005")


	--★★ノワール★★:どうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010006")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:問題ありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:どうぞ<br>ご用件をおっしゃってください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あー、いや<br>そんなかしこまる必要もないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010010")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園生活にはもう慣れた？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい。問題ありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010013")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そっか。ならいいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010014")


	--★★ノワール★★:ただ、もしなにか困ったことがあったら<br>そのときは遠慮なく言って欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010015")


	--★★ノワール★★:大したことはできないかもしれないけど<br>できる限り力になるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010016")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:まぁ、俺も先輩ヅラできるほど<br>この辺に詳しいわけじゃないんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:お気遣いありがとうございます<br>ですが、その必要はありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私がこの学園へ<br>来たばかりなのは確かですが
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010022")


	--★★ティルフィング★★:この時代のことがまったく分からない<br>というわけではありませんから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010023")


	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010024")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:マスターの手で顕現したさいに<br>あなたのもつ知識はある程度共有されましたから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:ですので、今のログレスや学園のことも<br>概ね把握できているのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:そ、そうだったのか…<br>俺、まだ勉強不足でさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010028")


	--★★ノワール★★:ティルフィングも色々わからなくて<br>困ってるんじゃないかと思ってたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:けど、それも杞憂だったみたいだな<br>ちょっと安心したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010030")


	--★★ティルフィング★★:ご心配をおかけし申し訳ありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いやいや、謝らないでくれ<br>俺が勝手に心配しただけだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010032")

	change_face(Actor001,"Smile")

	--★★ノワール★★:あ、ただ、別に困ったことがなくても<br>いつでも声かけてくれていいからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:やっぱり、ひとりよりは<br>誰かと一緒のほうが楽しいだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:楽しい？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010036")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:楽しい、ですか…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:誰かと一緒にいるときは<br>楽しいという感情を抱くものなのですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィング？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010040")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、あー<br>えーっと…そうだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010041")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ティルフィングのことを知ってる人<br>どこかにいないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010042")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ほら、直接の知り合いじゃなくても<br>ウワサとか伝承を聞いたことある人とかさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:そんな人なら<br>キミも一緒にいやすいだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010044")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:いいえ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010048")


	--★★ティルフィング★★:かつての私を記憶する者は<br>もうどこにもいません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010049")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:あの地に突き立つ剣となった私も…<br>そうなる前の、私も
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010051")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、悪いこと聞いたな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01010052")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:いいえ<br>お気になさらず
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:…すみません、マスター<br>これ以上お話がないようであれば、私はここで
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_01010054")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ1_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
