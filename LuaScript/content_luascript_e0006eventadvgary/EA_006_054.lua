-- このluaスクリプトは、EA_006_054.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114093_01","114093_01_h")
Include("content_adv_advsmall_114093_01","Template114093_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114093_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName114093_01,CameraPos114093_01_003)
	Camera002 = SetTemplate("Actor011",nil,CharaPos114093_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName114093_01,CameraPos114093_01_001)
	InitializeTemplateRandomCamera114093_01()
	InitializeTemplate114093_01()
-- ▼直接出力
load_image("201010071",  "content_still_20101007_image","201010071_StillImage")
load_image("201010072", "content_still_20101007_image","201010072_StillImage" )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114093)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_2DOnly("101025","001","101025001")
	Actor003 = InitializeCharacter_2DOnly("101024","001","101024001")
	Actor004 = InitializeCharacter_2DOnly("101018","001","101018001")
	Actor005 = InitializeCharacter_2DOnly("101027","001","101027001")
	Actor006 = InitializeCharacter_2DOnly("101026","001","101026001")
	Actor007 = InitializeCharacter_2DOnly("101022","001","101022001")
	Actor008 = InitializeCharacter_2DOnly("101014","001","101014001")
	Actor009 = InitializeCharacter_2DOnly("101023","001","101023001")
	Actor010 = InitializeCharacter_2DOnly("101019","001","101019001")
	Actor011 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor011")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor011,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★アーサー★★:いやあ、色々大変だったようだが<br>とりあえず無事花見が開催できてよかった！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540003")

	change_face(Actor001,"Normal")

	--★★アーサー★★:戦の最中だからこそ<br>花を愛でる心の余裕を忘れてはいけない
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540004")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力

	--★★アーサー★★:さあ、美味い飯を食いながら<br>皆で楽しい時間を過ごそうじゃないか
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★アーサー★★:
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540006")

	change_face(Actor001,"Normal")

	--★★アーサー★★:…必ずな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540007")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("201010071", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.6154,0.6154)
wait_time(0.6)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア","0028")
-- ▲直接出力

	--★★クレア★★:…美味しい！
	Talk(Actor002,"CHRNAME_CLARE","simple","N","EA_006_0540011")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:確かに。料理が得意とは聞いていたが<br>これほどとは…
	Talk(Actor003,"CHRNAME_BORS","simple","N","EA_006_0540012")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力

	--★★ラグネル★★:それに外で食べるってのがまた<br>開放感あっていいよねー
	Talk(Actor004,"CHRNAME_RAGNAR","simple","N","EA_006_0540013")

-- ▼直接出力
PlayPartVoiceDirect("ディンドラン","0010")
-- ▲直接出力

	--★★ディンドラン★★:あら、パー坊ったら口の周りに<br>ソースがついていますよ
	Talk(Actor005,"CHRNAME_DINDRANE","simple","N","EA_006_0540014")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0019")
-- ▲直接出力

	--★★パーシヴァル★★:
	Talk(Actor006,"CHRNAME_PERCIVAL","simple","N","EA_006_0540015")


	--★★パーシヴァル★★:あ、ちょっと！やめてくれ義姉さん！<br>自分で拭けるから！！
	Talk(Actor006,"CHRNAME_PERCIVAL","simple","N","EA_006_0540016")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("201010072", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.6154,0.6154)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒
fadein(FADE_TIME)
wait_time(FADE_TIME)
turn_lookat(Actor011,Actor001,0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0003")
-- ▲直接出力

	--★★モルドレッド★★:こんなときに花見とは呑気なもんだぜ<br>頭がお花畑かよ、まったく
	Talk(Actor007,"CHRNAME_MORDRED","simple","N","EA_006_0540017")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0010")
-- ▲直接出力

	--★★トリスタン★★:
	Talk(Actor008,"CHRNAME_TRISTAN","simple","N","EA_006_0540018")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0012")
-- ▲直接出力

	--★★クラリス★★:モルくん～！モルくんが好きそうな<br>料理たくさんもらってきました～
	Talk(Actor009,"CHRNAME_CLARICE","simple","N","EA_006_0540019")


	--★★クラリス★★:お花見、楽しいですね～
	Talk(Actor009,"CHRNAME_CLARICE","simple","N","EA_006_0540020")


	--★★クラリス★★:モルくんが案内してくれたおかげで<br>迷わずに来られてよかったです～
	Talk(Actor009,"CHRNAME_CLARICE","simple","N","EA_006_0540021")


	--★★モルドレッド★★:うるせぇ、余計なこと言うんじゃねぇ
	Talk(Actor007,"CHRNAME_MORDRED","simple","N","EA_006_0540022")


	--★★トリスタン★★:………
	Talk(Actor008,"CHRNAME_TRISTAN","simple","N","EA_006_0540023")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0010")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor010,"CHRNAME_ISOLDE","simple","N","EA_006_0540024")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start(Camera001)
hide_image(STILL_SWITCH_TIME)
wait_time(0.6)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:うんうん。皆、楽しそうでいいな<br>円卓の絆がまたひとつ強くなった！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540026")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor011,"to  Std_Talk")

	--★★ケイ★★:そう簡単にいけばいいがな
	Talk(Actor011,"CHRNAME_KAY","speech","L","EA_006_0540027")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor011,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:さっき言っただろう？<br>積み重ねが大事なんだよ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540028")

	PlayAction(Actor001,"to  Std_Talk")

	--★★アーサー★★:ガレスだってそうだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540029")


	--★★アーサー★★:ガレスの美味い飯は皆が集まって<br>卓を囲む理由となり
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540030")


	--★★アーサー★★:そして彼女のまっすぐな想いが届いたから<br>こうして皆がひとつになった
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:これこそ円卓の騎士六ノ座ガレスの役割だ<br>なあ、義兄さん
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540032")

	play_head_motion(Actor011, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ","0013")
-- ▲直接出力
	change_face(Actor011,"Sad")

	--★★ケイ★★:…認めるのが遅いと言いたげだな
	Talk(Actor011,"CHRNAME_KAY","speech","L","EA_006_0540033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0048")
-- ▲直接出力

	--★★アーサー★★:いやいや、そんなことは
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540035")

	change_face(Actor011,"Anger")

	--★★ケイ★★:私は貴公とちがって慎重なんだ<br>いや、貴公の分まで慎重、が正しいか
	Talk(Actor011,"CHRNAME_KAY","speech","L","EA_006_0540036")

	PlayAction(Actor011,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ケイ","0010")
-- ▲直接出力
	change_face(Actor011,"Smile")

	--★★ケイ★★:だが…まぁ――彼女が積み重ねた努力と<br>それに伴う結果を否定する気もない
	Talk(Actor011,"CHRNAME_KAY","speech","L","EA_006_0540037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力

	--★★アーサー★★:フラワーグッドフレンド作戦は<br>一日にして成らず、だ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_006_0540039")

	EndPlay()
end

