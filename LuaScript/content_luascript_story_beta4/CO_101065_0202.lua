-- このluaスクリプトは、CO_101065_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.6, 0.2, 0.9, 0.6} , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_TextOnly()
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_TextOnly()
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

	--★★ノワール★★:あんたはデキる女性だ。キッスさん俺に力を貸してくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020002")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ん～、物足りないわねもう少し頑張って♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020003")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:くっ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Serious")

	--★★ノワール★★:俺にはあんたの力が必要なんだキッスさん。俺の力になってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:もっと魂をぶつけて、ラビットちゃん！キミが欲しがってるものはなんなの？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:俺にはあんたが必要だ！付き合ってくれ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020009")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "驚き")
-- ▲直接出力

	--★★市民（中年男）②★★:おいおいこんな真昼間から告白かよ…
	Talk(Actor006,"NPCNAME_0268","speech","N","CO_101065_02020011")

-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:あいつキャメ学の生徒さんだろ？若いのにずいぶん大物を狙うもんだねえ
	Talk(Actor004,"NPCNAME_0268","speech","N","CO_101065_02020012")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ！えっ！？い、いや、違う！待って待って待って待って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "肯定2")
-- ▲直接出力

	--★★市民（男）★★:どうなるかわかんねえけど応援してやろうぜ、ウチらでよ
	Talk(Actor005,"NPCNAME_0268","speech","N","CO_101065_02020014")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定2")
-- ▲直接出力

	--★★市民（中年男）②★★:あんまり青少年を泣かしてやるなよタマ…じゃねえ、キッスちゃん
	Talk(Actor006,"NPCNAME_0268","speech","N","CO_101065_02020015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:なんか誤解されてる！？き、キッスさんからも言ってやってくれ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力

	--★★キッス★★:もう…お姉さん、せっかちな子は嫌いよ？ちゃんと順を追って仲良くなりましょ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020018")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:そうじゃなくてっ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020019")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ。合格～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★キッス★★:やればできるじゃないさすがアタシが見込んだラビットちゃん♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020022")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はああ～…俺はいったい、なにをしてるんだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020024")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:頑張ったラビットちゃんにはご褒美をあげないとね～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ご褒美…そうだ、情報を…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020026")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:欲しがりさんなラビットちゃんにぴったりのお仕事があるのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020027")


	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力

	--★★キッス★★:盗賊たちがここからそう遠くないところに根城を構えちゃってね。退治してほしいの
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020029")

	change_face(Actor002,"Smile")

	--★★キッス★★:退治だけじゃなく盗品回収までできたら報酬、弾んじゃうわ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020030")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、俺はそういうハナシを聞きたいわけじゃなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020031")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:そ・れ・に…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020033")

	change_face(Actor002,"Smile")

	--★★キッス★★:もしかしたら…キミが知りたがってるナニカが見つかるかも♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_02020036","CO_101065_02020037")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか？それなら引き受けようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020039")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:さっすが、ラビットちゃんハナシが早いわね～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020040")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんだがいいように丸め込まれた気がする…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺を騙そうとしてないか？手がかりが見つかるって保証はあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020043")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:さあ、それはどうかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020044")

	change_face(Actor002,"Normal")

	--★★キッス★★:でも、絶対にないっていう保証もない
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020045")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:その答えはズルいと思うんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020046")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかったやるよ、やればいいんだろ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020048")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ。キミは本当にいい表情を見せてくれるわね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020049")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:で？その盗賊の居場所は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_02020051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:ここに纏めてあるわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020052")

	change_face(Actor002,"Smile")

	--★★キッス★★:盗品と一緒に書類の束があると思うからあわせて回収、お願いね～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_02020054")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_キッス_ランクアップ2_3")
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
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
