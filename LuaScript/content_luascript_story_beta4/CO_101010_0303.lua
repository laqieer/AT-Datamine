-- このluaスクリプトは、CO_101010_0303.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やっと…終わった………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:後日、今日の復習を兼ねた試験をするからな<br>しっかり復習しておけよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:ぐええ………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:もうちょっと優しくしてくれてもいいだろ<br>こっちはまだこの環境に慣れてないんだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030006")


	--★★ノワール★★:せめて剣の修業とかなら<br>こっちもやる気もでるんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:もちろんそっちも大事だが<br>座学を疎かにしてはいけない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030009")


	--★★ランスロット★★:お前には伸びしろがあるんだ、ノワール<br>今学ばずしていつ学ぶ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:さっきの子たちが逃げだした気持ち<br>わかる気がするよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030012")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:さっきの…？<br>ああ、あの女子生徒たちか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030013")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:結局なにを質問したかったのか<br>わからなかったが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030014")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:妙に俺の好みに詳しかったな<br>授業でそういった話はしたことがないんだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030015")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:あー、それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030016")


	--★★ランスロット★★:もしかして、お前が？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030017")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:ごめん、勝手に喋っちゃって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:いや、気にするな<br>別に隠しているわけではないしな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030021")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:それにしても…よく覚えていたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう簡単に忘れるわけないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そうだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030026")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あんたの好みが<br>変わってるかも知れないとは思ったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030027")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そう簡単に人は変わらないさ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030028")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:お前だって相変わらずトマトが嫌いなんだろ？<br>食堂で残しているのを見たぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんでそんなとこ見てるんだよ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力

	--★★ランスロット★★:ははは。見ていたつもりはないんだ<br>たまたま目に入ってしまったから
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03030032")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:笑うな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03030033")

-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
