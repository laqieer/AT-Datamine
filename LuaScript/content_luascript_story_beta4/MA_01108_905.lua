-- このluaスクリプトは、MA_01108_905.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★アーサー★★:ノワールか<br>どうした、俺になにか用事でも？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あー、えーっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050003")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ぺレス王への手土産<br>なにがいいかなと相談に来たんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:マーケットの露店でな<br>サバを挟んだパンが売り出され始めたんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:サ、サバを挟んだパン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050006")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:銀卓騎士たちは喜ぶかもしれないけど<br>ぺレス王が食べるかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050007")


	--★★アーサー★★:サバは栄養満点なんだぞ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:いや、そういう話じゃなくてさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050009")

	change_face(Actor002,"Normal")

	--★★アーサー★★:…お前の元気な顔が一番の土産じゃないか？<br>昔、会ったことがあるんだろう？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050010")

-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050011")


	--★★ノワール★★:えっと、その、このあいだはごめん<br>もう大丈夫だから…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050012")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
on_camera(Camera002)
-- ▲直接出力

	--★★アーサー★★:俺よりももっとお前のことを<br>心配していた連中がいるだろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050013")

	change_face(Actor002,"Smile")

	--★★アーサー★★:彼らにも元気な顔を見せてやれ<br>きっと喜ぶぞ、なあ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050014")


	--★★ギネヴィア★★:気づいてたのね
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01108_9050016")

-- ▼直接出力
CloseTalkWindow()
on_camera(RndCamera009)
-- ▲直接出力
-- ▼直接出力
set_rot(Actor001,{0,-75,0})
set_enable_auto_lookat(Actor005,false)
lookat_weight(Actor005,1.0,0.5,1.0,0.5)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.5)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-180,0.7)
wait_time(0.7)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:俺からは丸見えだったからな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050018")


	--★★ランスロット★★:行けるのか、ノワール？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01108_9050019")


	--★★ノワール★★:心配かけたな、３人とも<br>俺はもう大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050020")

	change_face(Actor004,"Sad")

	--★★ディナタン★★:無理してない、兄さん？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01108_9050021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ついてきてくれるか、みんな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050022")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Yes")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Yes")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to  Std_Yes")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ギネヴィア★★:しょーがないわね～<br>泣き虫の傭兵ひとりじゃ心配だもん
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01108_9050023")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9050024")

	change_face(Actor002,"Normal")

	--★★アーサー★★:決まりだな。出発はX日後にしよう<br>みんな準備を怠るなよ<br>
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9050025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
