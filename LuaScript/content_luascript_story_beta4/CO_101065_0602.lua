-- このluaスクリプトは、CO_101065_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112041_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_008)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:はぁ～…<br>いらっしゃい、ラビットちゃん
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしたんだ？<br>今日は調子悪いのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020003")


	--★★キッス★★:調子が悪いっていうか…<br>お酒を飲んだ翌日はいつもこうなの…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")

	--★★キッス★★:うっ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020006")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:二日酔いか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020008")


	--★★ノワール★★:（この間、俺が巻き込まれた次の日も<br>こんな感じだったのかな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101065_06020009")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力

	--★★キッス★★:またケイ卿にも怒られちゃったし…<br>反省しなきゃ…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:いつも飲むとあんな感じなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020012")

-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力

	--★★キッス★★:あんな感じってどんな感じ…？<br>アタシ、そんなひどい姿してた…？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_06020015","CO_101065_06020016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…大丈夫<br>ひどくなかったよ、ぜんぜん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020018")

-- ▼直接出力
PlayPartVoice("キッス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:本当～？<br>変なこと口走ったりとかしてない…？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:してないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんていうか…ひどかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020022")

-- ▼直接出力
PlayPartVoice("キッス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:ひどかったって、どんなふうに…！？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020023")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺の口からはちょっと言えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020024")

-- ▼直接出力
PlayPartVoice("キッス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★キッス★★:余計に気になるじゃない…！
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020025")

	goto Block1end

::Block1end::
	change_face(Actor001,"Surprise")

	--★★ノワール★★:覚えてないんだな飲んだときのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:記憶、飛んじゃうのよね…アタシ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020028")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もう飲まないほうがいいんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "落胆")
-- ▲直接出力

	--★★キッス★★:ラビットちゃんまでケイ卿とおんなじこと言って…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020030")


	--★★キッス★★:オトナには飲まなきゃやってられない日だってあるのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020031")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力

	--★★キッス★★:あいつらがもっと簡単にしっぽ出してくれたら楽なのに～！
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020032")

	change_face(Actor002,"Surprise")

	--★★キッス★★:ヴッ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020034")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あいつら…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020035")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:やっぱり今日はもうおウチに帰ることにするわ～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★キッス★★:またね、ラビットちゃん…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_06020038")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera001)
end
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あ、ああお大事に…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020039")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Camera004= setup_small_camera_resetting(Actor004,CharaPos112041_03_006,CameraPos112041_03_006)
Camera005= setup_small_camera_resetting(Actor004,CharaPos112041_03_007,CameraPos112041_03_007)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "肯定2")
-- ▲直接出力

	--★★市民（男）★★:ずいぶん荒れてたな～タマちゃん
	Talk(Actor005,"NPCNAME_0230","speech","N","CO_101065_06020041")


	--★★ノワール★★:タマちゃん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020042")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:ああ、ボウズ知らねえのかタマってのはキッスの本名だよ
	Talk(Actor004,"NPCNAME_0231","speech","N","CO_101065_06020043")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:はぁ～っ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020044")

-- ▼直接出力
PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力

	--★★市民（男）★★:酒飲むとベラベラ喋っちまうんだ、自分のことだからみんなイロイロ知ってるぜ
	Talk(Actor005,"NPCNAME_0230","speech","N","CO_101065_06020045")


	--★★市民（男）★★:オフの日は化粧しなくていいから最高だとか<br>外出しないなら朝から晩までパンイチだとか
	Talk(Actor005,"NPCNAME_0230","speech","N","CO_101065_06020047")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:パン…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020048")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定2")
-- ▲直接出力

	--★★市民（中年男）★★:遠い田舎の生まれで12人きょうだいの長女でこないだ姪っ子ができたとか
	Talk(Actor004,"NPCNAME_0231","speech","N","CO_101065_06020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:め、姪っ子…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020050")

-- ▼直接出力
PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力

	--★★市民（男）★★:昔ミッションに失敗して以来何者かに命を狙われ続けてるだとか
	Talk(Actor005,"NPCNAME_0230","speech","N","CO_101065_06020052")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "笑い")
-- ▲直接出力

	--★★市民（中年男）★★:世界中に二桁を超える数の婚約者がいるだとか
	Talk(Actor004,"NPCNAME_0231","speech","N","CO_101065_06020053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:えっ？<br>えっっ？？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020054")

-- ▼直接出力
PlayPartVoice("市民_男1", "笑い")
-- ▲直接出力

	--★★市民（男）★★:去年買った服が着られなくなってダイエットを始めただとか
	Talk(Actor005,"NPCNAME_0230","speech","N","CO_101065_06020055")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "悩む")
-- ▲直接出力

	--★★市民（中年男）★★:とある組織から派遣されたスパイでこの国の情報を嗅ぎまわってるとか
	Talk(Actor004,"NPCNAME_0231","speech","N","CO_101065_06020056")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょ、ちょっと待って<br>情報量が多すぎて脳の処理が追い付かない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "喜び")
-- ▲直接出力

	--★★市民（男）★★:どこまでが本当でどこからがウソかはわからねえけどさ
	Talk(Actor005,"NPCNAME_0230","speech","N","CO_101065_06020060")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男1", "喜び")
-- ▲直接出力

	--★★市民（中年男）★★:俺たちみんな彼女が好きだからよ変に詮索しないことにしてんだ
	Talk(Actor004,"NPCNAME_0231","speech","N","CO_101065_06020061")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:は、はあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:オトナって、大変なんだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_06020063")

-- ▼直接出力
local trustParam = set_communication_rankup("キッス_コミュランク", "キッス_親密度")
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
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
