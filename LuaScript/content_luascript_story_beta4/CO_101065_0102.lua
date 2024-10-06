-- このluaスクリプトは、CO_101065_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-37,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
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
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:情報収集なら酒場、と思って来てみたけど…さすがにこの時間だと客が少ないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020002")


	--★★ノワール★★:とりあえずマスターに話を聞いてみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020003")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力

	--★★キッス2★★:あらあら？ラビットちゃんじゃな～い♪
	Talk(Actor004,"CHRNAME_KISS","speech","L","CO_101065_01020005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020007")

-- ▼直接出力
　--時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor002)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.6, 0.08, 0.8, 0.8} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:情報屋の…えっと、キッスさん…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020009")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:『情報屋』なんて野暮ったい呼びかたはやめて
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★キッス★★:『エージェント・キッス』でよろしくね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020011")

	change_face(Actor002,"Normal")

	--★★キッス★★:それで、こんな時間にどうしたの？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさんがいるならちょうどいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ちょっと調べたいことがあって来たんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020014")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:お仕事のお話？ラビットちゃんは真面目でいい子ねぇ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あのさ。バルバロイを信奉する妙な集団がいるって噂があるんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:バルバロイを信奉する集団？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020018")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。にわかには信じられない話だけどなにか知っていたら教えてくれないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020020")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:そうねぇ…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020022")

	change_face(Actor002,"Smile")

	--★★キッス★★:有望そうよね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020024")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020026")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:実はね、前から思ってたのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★キッス★★:ラビットちゃんって本当将来有望そうな子ね～って♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020029")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ええ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020031")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:ねぇねぇちょっとアタシのこと口説いてみない？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:はあ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020033")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ほら、情報が欲しいんでしょ？うまく口説けたら教えちゃうかもよ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020034")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ええ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_01020037","CO_101065_01020038")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:き、急にそんなこと言われても困るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020040")

	change_face(Actor001,"Sad")

	--★★ノワール★★:これまで女性を口説いたことなんてなかったしこれからだって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020041")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:あら、そんなことないわよ？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020042")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★キッス★★:相手を気分よくさせて会話を円滑に進める…交渉の基本中の基本だと思うけど♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020043")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:しかたないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あー、ンンッ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020047")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今日も綺麗だな、キッスさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020048")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんたはとっても魅力的で…魅力…その…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020049")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("キッス", "否定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ぶっぶーそんなんじゃ全然ダメダメよ～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020050")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:やっぱり俺には無理だ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020052")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ困ってるわね～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020053")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:誰のせいだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:ア・タ・シ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020055")

	change_face(Actor002,"Normal")

	--★★キッス★★:残念でした。ラビットちゃんは課題をクリアできなかったので
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020056")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:今回の交渉は失敗で～す
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020057")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★キッス★★:諦めずにまた挑戦しに来てね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020058")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？それはつまり…連中についてなにか知ってるってこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020059")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:さて、どうでしょう～？それじゃ、ばいば～い♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_01020060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えええええ…ま、またやるのか、あれを？俺が？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_01020062")

-- ▼直接出力
local trustParam = set_communication_acquired("キッス_コミュランク", "キッス_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
