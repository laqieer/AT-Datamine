-- このluaスクリプトは、MA_01B109_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera002 = SetTemplate("Actor002",-99.1,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	Camera003 = SetTemplate("Actor003",126,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera004 = SetTemplate("Actor004",183.1,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera006 = SetTemplate("Actor006",-11.1,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	Camera007 = SetTemplate("Actor007",158.53,CharaPos110051_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_007)
	Camera008 = SetTemplate("Actor008",-97.9,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ガラハッド★★:──やはりこんな不愉快な布で<br>人前に出るわけにはいきませんよ、姉上
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B109_170002")


	--★★フィエナ★★:決まりを守り、足並みを揃える
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170004")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★フィエナ★★:学園っていうのは<br>そういうことを学ぶ場でもあるでしょ？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170005")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera006)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力

	--★★ノワール★★:ガラハッド…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_170007")

	PlayAction(Actor006,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:…よろしく
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B109_170009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to Greet_one")

	--★★フィエナ★★:おまたせ<br>ランスロット、ノワール
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170010")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:…フィエナ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B109_170011")

	PlayAction(Actor005,"to Bow")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:こんにちは。円卓の騎士のみなさま<br>ガラハッドとはお友達だよね
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170012")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:コルベニック城からの<br>おつかいに寄越された子、だよね？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B109_170013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ボールス★★:…パーシヴァル
	Talk(Actor008,"CHRNAME_BORS","speech","L","MA_01B109_170015")

	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:おつかい…<br>そうだね、違いないよ
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B109_170016")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:張り合いないなあ<br>キミらは円卓に確執があるんだろ？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B109_170017")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ボールス★★:アーサー王が仰せであった留学生とは<br>お前たちのことなのか…？
	Talk(Actor008,"CHRNAME_BORS","speech","L","MA_01B109_170018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:自ら申し出てくれたよ<br>再留学がしたいと
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_170019")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:もしや継承者クンがコルベニック城から<br>カレドニアを退けたお礼でも言いに来たのかな？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B109_170020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:………コルベニック城は、落ちました
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B109_170021")

	open_cutin(3,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor003,"Surprise")
	on_cutin(3,Actor004,"Surprise")
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	close_cutin()
	change_face(Actor005,"Anger")

	--★★フィエナ★★:お願いに来たの<br>円卓の騎士様たちに
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:お願い？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_170024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★フィエナ★★:お困りだよね？<br>広い広―いブリテンで聖杯をどうやって探すか
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170025")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★マーリン★★:…何か手立てがございますか？<br>フィエナ嬢
	Talk(Actor007,"CHRNAME_MERLIN","speech","L","MA_01B109_170026")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★フィエナ★★:聖杯まで案内出来るよ
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170027")

	PlayAction(Actor005,"to  Std_Joy")

	--★★フィエナ★★:この『聖杯城の巫女』<br>──フィエナちゃんなら
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170028")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ほ、本当か…！？どうやって…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_170030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:いっしょに奇跡を、探してくれる？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_170031")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
