-- このluaスクリプトは、MA_01108_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")

	--★★ガラハッド★★:大所帯だな
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_040002")


	--★★イゾルデ★★:団体行動は苦手かしら？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01108_040004")

	PlayAction(Actor005,"to  Std_Sad01")
	change_face(Actor005,"Sad")

	--★★ガラハッド★★:い、いや、すまない。道案内のみなのにここまでしてもらうのが申し訳なくて、だな…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_040005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:ボクらあの国にちょっと縁が合ってね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01108_040006")


	--★★トリスタン★★:コーンウォール王にカレドニアとの戦の話もしないとでしょ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01108_040007")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ありがとうトリスタン、イゾルデ俺やランスロットじゃ馴染みのない場所だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_040008")


	--★★イゾルデ★★:薬草の群生地への案内も任せなさい
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01108_040009")


	--★★トリスタン★★:それにまあ<br>監視対象が集まってくれて都合が良かったよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01108_040010")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:…ガラハッドがやましいことをするとでも？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_040011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:最強騎士と新進気鋭の騎士にちょっかいを出されては困るものね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01108_040012")

	change_face(Actor006,"Smile")

	--★★アステラ★★:ふふ。そうね<br>お目付け役が必要ね
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01108_040014")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
	change_face(Actor005,"Anger")

	--★★ガラハッド★★:ちょ、ちょっかいなど出すか！！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_040015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor002,Camera002,EntryData110071_04_07,CameraAssetBundleName110071_04,CameraPos110071_04_107)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
lookat_weight(Actor005,1.0,0.5,1.0,0.5)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",0.5)
-- ▲直接出力

	--★★ランスロット★★:ガラハッド、アステラそろそろ出発するぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_040017")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:気安くその名を呼ぶなランスロット
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_040019")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:あ…すまない…<br>よろしく…お願いする
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_040021")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★トリスタン★★:ほら。ちょっかいが出た
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01108_040022")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
