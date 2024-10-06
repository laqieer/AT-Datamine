-- このluaスクリプトは、MA_01C109_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_001)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Door  = get_object("geo_door_R_02")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
RagPos1 = {-3.407, 0, -6.637}
RagRot1 = {0,316.9699,0}
-- ▲直接出力
-- ▼直接出力
RagPos2 = {1.536, 0, -1.854,   90}
RagRot2 = {0,181.7,0}
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,RagPos1)
set_rot(Actor003,RagRot1)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-2.02, 0, -6.3})
set_rot(Actor002,{0,50.2,0})
-- ▲直接出力
-- ▼直接出力
MerlinPos = {CharaPos110041_02_006[1],CharaPos110041_02_006[2],CharaPos110041_02_006[3],38.4}
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力

	--★★アーサー★★:いいものだな<br>青春というのは
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030002")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★アーサー★★:若者がハツラツと命を燃やし<br>二度と戻らない日々を駆け抜ける
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー","肯定2")
-- ▲直接出力

	--★★アーサー★★:その瞬きは尊い<br>だから守らなければならない
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(Camera001)
set_rot(Door,{0,20,0})
IN_WALK(Actor002,MerlinPos)
-- ▲直接出力

	--★★アーサー★★:そこに疑問を抱けば<br>みなに合わせる顔がない
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030005")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:その王たる仮面の溝から<br>また覗きのような真似をなさって
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー","喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:理事長として<br>学園を見守っていると言ってほしいな！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030009")

-- ▼直接出力
 --PlayPartVoice("マーリン","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:見守るのがお好きですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030010")

-- ▼直接出力
 --PlayPartVoice("アーサー","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:俺は教師ではないからな<br>生徒を見守ることしかできないわけだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★アーサー★★:間違った選択をしても<br>正してやることができない
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン","落胆")
-- ▲直接出力

	--★★マーリン★★:そうかもしれません<br>でも間違うのが若人というものでは？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030013")

-- ▼直接出力
 --PlayPartVoice("アーサー","肯定2")
-- ▲直接出力

	--★★アーサー★★:それもそうだ<br>だからこそ教師がいる
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030014")


	--★★アーサー★★:だとすると<br>大人の間違いは、誰が正すのだろうな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:…アーサー様
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030016")

-- ▼直接出力
bgm_play("BGM_ADV_Serious2")
-- ▲直接出力

	--★★マーリン★★:その仮面<br>いかがいたします？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030018")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力

	--★★アーサー★★:…心地良かったよ<br>夢のようだった
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030019")

-- ▼直接出力
 --PlayPartVoice("マーリン","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:あなたの本懐──<br>止めることはできません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030020")

	change_face(Actor002,"Anger")

	--★★マーリン★★:ですがお力添えも、いたしません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
SkipDefaultMotion(Actor003)
change_face(Actor003,"Sad")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:なぜなら私はこの学び舎を愛しています<br>あなたがここを想っているように。同じように
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030022")

	change_face(Actor002,"Normal")

	--★★マーリン★★:貴方の行いの是非もまた<br>若人が決めることでしょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030023")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー","肯定2")
-- ▲直接出力

	--★★アーサー★★:………忌憚なき意見を聞きたいな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030024")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
PlayAction(Actor003,"to  Std_Surp")
-- ▲直接出力

	--★★アーサー★★:ラグネル
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor001,"to Std_Loop")
set_pos(Actor003,RagPos2)
set_rot(Actor003,RagRot2)
turn_chara(Actor001,41.7,0)
turn_chara(Actor002,16,0)
lookat_delay_weight(Actor001, 1.2, 0.5, 1.0, 0.2,1.0)
keep_ik_lookat(Actor001,Actor003,"J_Head")
set_rot(Door,{0,0,0})
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ラグネル","悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:…ガ、ガウェインが、心配しています
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01C109_030027")


	--★★ラグネル★★:いつものアーサー様じゃない、と<br>だからあたしも、気がかりで──
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01C109_030028")

-- ▼直接出力
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力

	--★★アーサー★★:<ruby=ガウェイン>正直者</ruby>の代わりに盗み聞きを？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C109_030029")

-- ▼直接出力
 --PlayPartVoice("マーリン","落胆")
-- ▲直接出力

	--★★マーリン★★:…わかっていて、聞かせたのでしょう？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030031")

-- ▼直接出力
 --PlayPartVoice("ラグネル","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:え………？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01C109_030032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★マーリン★★:誰よりも正直な彼だけは<br>置いていくことに抵抗があるのでしょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030033")


	--★★ラグネル★★:どういうことですか…？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01C109_030034")

	change_face(Actor002,"Normal")

	--★★マーリン★★:ですから<dot>アーサー<br></dot><br>貴方が出て行かれるというのなら──
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030035")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
CloseTalkWindow()
wait_time(0.7)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マーリン★★:私たちは、ここまでです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C109_030037")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Serious2")
RagPos1 = {-3.407, 0, -6.637}
RagRot1 = {0,316.9699,0}
RagPos2 = {1.536, 0, -1.854,   90}
RagRot2 = {0,181.7,0}
MerlinPos = {CharaPos110041_02_006[1],CharaPos110041_02_006[2],CharaPos110041_02_006[3],38.4}
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
