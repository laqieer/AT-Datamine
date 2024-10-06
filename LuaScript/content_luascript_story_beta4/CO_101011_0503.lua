-- このluaスクリプトは、CO_101011_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
-- ▼直接出力
Hide(Actor003)
lookAtWeight = {0.4, 0.08, 0.7, 0.6}
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor001, Actor002, "J_Head")
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor004, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:このあいだの<br>あのガラス玉だけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:うん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030003")


	--★★ノワール★★:なにか特別な効果を秘めた品なのか？<br>魔力を秘めている、とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:あれはね、まだ小さな頃<br>お姉ちゃんがパパにもらったものなの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:それを<br>なんでギネヴィアが持ってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05030006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:パパがお姉ちゃんにあのガラス玉を渡すときに
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030007")


	--★★ギネヴィア★★:「幸せを運んでくれる魔法が<br>込められてるんだよ」って言っててね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:わたし、それを聞いたら<br>どうしてもあのガラス玉が欲しくなっちゃって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030009")


	--★★ギネヴィア★★:別のプレゼントをもらったのにも関わらず<br>大騒ぎしちゃったの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030010")

	open_select_window_tag(Actor001,"Normal","CO_101011_05030012","CO_101011_05030013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かのものを欲しがって大騒ぎか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05030015")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは<br>なんだかその光景、目に浮かぶな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05030016")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:うるさい<br>黙って聞きなさい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで<br>ガラス玉をもらえたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05030019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:どうどう、焦らない焦らない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:これから話したげるから<br>ゆっくり聞きなさい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030021")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:でもね、お姉ちゃんはくれなかった<br>意外に頑固なのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030023")


	--★★ギネヴィア★★:見かねたパパが<br>似たガラス玉をプレゼントしてくれたんだけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:なにか「これじゃない」って気がしたのよね<br>だから、わたしは満足できなくて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030025")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そのあとも何度も何度もちょうだいって<br>ダダをこねたんだけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:やっぱりお姉ちゃんはくれなかった<br>ホントに頑固なのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030027")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
keep_ik_lookat(Actor001, Actor003, "J_Head")
keep_ik_lookat(Actor002, Actor003, "J_Head")
keep_ik_lookat(Actor003, Actor002, "J_Head")
wait_time(0.7)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネマウア★★:…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_05030029")

-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:お、おね…！？<br>用事は終わったの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:はい<br>おかげさまで
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_05030031")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、あーっと<br>俺もそろそろ帰らないとな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05030032")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(0.5)
se_play("SE_ADV_MA_01105_24_Footstep")
wait_time(CHARA_IN_IN)
wait_time(CHARA_IN_WAIT + 1.5)
Hide(Actor001)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:頑固なのではありません<br>愛のあるしつけです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_05030034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ギネマウア★★:わがままな妹への、ね…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_05030035")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あ、あはははは、は…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05030037")

-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
lookAtWeight = {0.4, 0.08, 0.7, 0.6}
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
