-- このluaスクリプトは、MA_01C112_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_006)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
 --set_common_look_at(Actor002,Actor001)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ルーシャス★★:こうもすべてを?っ攫われるとは<br>笑えてくるな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260002")

	change_face(Actor002,"Normal")

	--★★ルーシャス★★:どうやら余は<br>あやつの王の器を見誤っていたようだ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサーのことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_260005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ルーシャス★★:余が相見えたとき<br>あやつにバルバロイの力は宿っていなかった
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260006")

	change_face(Actor002,"Normal")

	--★★ルーシャス★★:この学園で青春だなんだと<br>手垢のついた理想を述べていた男のまま
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260007")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ルーシャス★★:…だとしたらあの力はなんだ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260008")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あの力？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_260009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:幾度も魔女やバルバロイと対峙してきた<br>余にも味わったことのない力だ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260010")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:あやつはバルバロイを意のままに操り<br>聖杯を破壊した…いや…違うな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260011")


	--★★ルーシャス★★:バルバロイが奴の都合のいいように動いている<br>というほうが正しいかもしれん
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260012")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなこと、できるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_260013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:普通はできぬ芸当であろう。<br>だが…
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260014")

	change_face(Actor002,"Sad")

	--★★ルーシャス★★:アーサーの強さは得体が知れん<br>相手にするのは得策ではない
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260015")

	change_face(Actor002,"Normal")

	--★★ルーシャス★★:それはおまえも感じたであろう
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260016")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:あやつに敵う者が<br>今のこの学園にいるとは思えないからな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ルーシャス★★:さあ、どうする<br>継承者よ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260018")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:それでも戦うしかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_260019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ルーシャス★★:自分なら勝てると？<br>さすがは継承者、たいそうな自信だ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:平時であれば下手な冗談でも<br>笑ってやったのだがな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C112_260021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
