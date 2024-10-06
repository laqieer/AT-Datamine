-- このluaスクリプトは、MS_002_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_01","100021_01_h")
Include("content_adv_advsmall_100021_01","Template100021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_01,CameraPos100021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos100021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName100021_01,CameraPos100021_01_001)
	InitializeTemplateRandomCamera100021_01()
	InitializeTemplate100021_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
Camera_EX = set_camera({-1.03, 1.342, -17.328,   3.012, 19.30601, 0,   15})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
setup_small_camera_start(Camera_EX)
wait_time(0.8)
-- ▲直接出力

	--★★アルハン★★:<ruby=ノワール>過去の継承者</ruby>が<br>封として遺した『<ruby=オーセンティック>根源の武器</ruby>』は二振り
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310003")


	--★★アルハン★★:きゃつらには過去の継承者との絆が刻まれ<br>次元を異にするほどの力がある
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310006")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アルハン★★:だが同質の身体を持ち<br><ruby=イミテーション>バルバロイの力をも得た敵</ruby>は三体
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310007")

	change_face(Actor001,"Normal")

	--★★アルハン★★:あれらは言葉を操っているように見えるが<br>虚ろに声を発すだけの傀儡…交渉の余地はない
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310009")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ロンギヌス★★:で、ですが…フライクーゲルが<br>帰って来てくれました
	Talk(Actor002,"CHRNAME_LONGINUS","speech","L","MS_002_0310010")

	change_face(Actor002,"Sad")

	--★★ロンギヌス★★:聖遺物の探索を打ち切ってまで──
	Talk(Actor002,"CHRNAME_LONGINUS","speech","L","MS_002_0310011")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0009")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アルハン★★:だがフライクーゲルの弾丸は<br>イミテーションに当たらなかった
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310012")

-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera_EX)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Anger")

	--★★アルハン★★:今のままでは<br>キサマたちの刃が届くこともないだろう
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310013")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ロンギヌス★★:………
	Talk(Actor002,"CHRNAME_LONGINUS","speech","L","MS_002_0310014")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:キサマら継守会のキラーズは<br>まだ、<dot>不完全な存在</dot>だ
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310015")


	--★★アルハン★★:『<ruby=オーセンティック>根源の武器</ruby>』には力及ばぬ<br>イミテーションにもな
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310017")

	change_face(Actor001,"Sad")

	--★★アルハン★★:手が足りぬ<br>このままでは勝機はないだろう──…
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310019")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ロンギヌス★★:では、マサムネたちに<br>戻ってきてもらってはどうでしょう？
	Talk(Actor002,"CHRNAME_LONGINUS","speech","L","MS_002_0310020")

-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera_EX)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0040")
-- ▲直接出力

	--★★アルハン★★:次の戦いまでに間に合わんだろうな
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310021")

	change_face(Actor001,"Normal")

	--★★アルハン★★:フライクーゲルが戻ってきてくれたのが<br>奇跡的と言っていいだろう
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310022")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0024")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ロンギヌス★★:そんな…
	Talk(Actor002,"CHRNAME_LONGINUS","speech","L","MS_002_0310023")


	--★★アルハン★★:手があるとすれば…<br>あやつを呼び戻すことか
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0310024")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName100021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
