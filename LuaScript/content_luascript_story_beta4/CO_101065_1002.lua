-- このluaスクリプトは、CO_101065_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_01","112041_01_h")
Include("content_adv_advsmall_112041_01","Template112041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_004)
	InitializeTemplateRandomCamera112041_01()
	InitializeTemplate112041_01()
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
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:はい、これで全部よ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020002")

	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ありがとう<br>…驚いたな、こんなにあるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020004")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:バルバロイや魔女を信奉する集団は<br>あいつら以外にもたくさんあるようよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:バルバロイや魔女なんて信じて<br>なにになるんだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力

	--★★キッス★★:気持ちはわかるけど<br>人間って弱いものだから
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020007")


	--★★キッス★★:間違っているとわかっていても<br>すがってしまう者もいるのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_10020010","CO_101065_10020011")
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
	change_face(Actor001,"Sad")

	--★★ノワール★★:だからといって<br>子供を巻き込むのは許せない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:そうよ<br>そのとおりよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020014")

	change_face(Actor002,"Normal")

	--★★キッス★★:だからこそ<br>アタシたちオトナが頑張らなくちゃいけない
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:弱いまま、誰かにすがるままじゃ<br>ずっと変わらない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:強くならなきゃダメだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020018")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:キミみたいな人が増えれば<br>世界が変わっていくもしれないわね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020019")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさんはこのあいだの一件以外でも<br>子供たちを救い出してるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:そうね、何回かだけれど
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020022")


	--★★ノワール★★:救い出した子供たちはどうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キッス★★:ご両親のもとに届けたり…アタシがもっとも信頼できる人に預けたりね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020024")


	--★★ノワール★★:もっとも信頼できる人って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020025")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:ナイショよ…まだね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それにしてもキッスさんの人脈には驚かされる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ケイと知り合いなのにも驚いたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020029")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:保護した子供たちをすぐに預けられる伝手もあるなんてな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（そもそもバルバロイ関連の依頼を扱ってるのが普通に考えてありえないんだけど）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101065_10020031")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020032")


	--★★キッス★★:こういうお仕事をしているといろんな所といろんな繋がりができるのよ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:すごい大雑把な説明だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:そして、そうやって作られていく人脈のなかで出会う
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020035")


	--★★キッス★★:これはっていうラビットちゃんを素敵なオトナにしてあげるのが…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020036")

	change_face(Actor002,"Smile")

	--★★キッス★★:アタシの趣味であり生きがいなの♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:素敵なオトナか俺も早くなりたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020039")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:もう…せっかちさんね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★キッス★★:でも、キミならなれるわよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020041")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:アタシが保証するわだって、キミってとってもイイ顔するもの♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10020043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力

	--★★キッス★★:（キミならきっとなれるわ世界を救い、未来を紡ぐ継承者にね）
	Talk(Actor002,"CHRNAME_KISS","mind","L","CO_101065_10020045")

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
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
