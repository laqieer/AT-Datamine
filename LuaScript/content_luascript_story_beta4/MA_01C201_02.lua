-- このluaスクリプトは、MA_01C201_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",81,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_007)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
lookat_weight(Actor001, 0.6, 0, 0.8, 0.2)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
lookWeight = {0.9, 0, 0.6, 0.35}
lookat_delay_weight(Actor002, lookWeight,0.5)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-1.904,0,1.614})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("101040250", "content_still_10104025_image", "101040250_StillImage")
-- ▲直接出力
-- ▼直接出力
lookobj_n = create_object("kara")
set_pos_object(lookobj_n,2.058, 1.2, 2.324)
-- ▲直接出力
-- ▼直接出力
lookobj_d = create_object("kara2")
set_pos_object(lookobj_d,3.554, 1.1, 2.553)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115150)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:実の兄のように慕う唯一無二の存在を失い<br>ノワールとディナタンは悲しみに暮れるのだった
	Talk(Actor004,"telop","narration","N","MA_01C201_021001")


	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01C201_021002")


	--★★テロップ★★:ねえ…兄さん<br>ランス兄ちゃんはどうして学園を出て行ったの？
	Talk(Actor004,"telop","narration","N","MA_01C201_021003")


	--★★テロップ★★:ランス兄ちゃんは<br>死ななきゃならなかったの？
	Talk(Actor004,"telop","narration","N","MA_01C201_021004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ねえ…兄さん<br>ランス兄ちゃんはどうして学園を出て行ったの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020002")


	--★★ディナタン★★:ランス兄ちゃんは<br>死ななきゃならなかったの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020003")

	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:ランス兄ちゃんだけじゃない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020006")


	--★★ディナタン★★:アーサー様もギネヴィアさんも<br>私たちのもとから離れていった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020007")


	--★★ディナタン★★:パーシヴァルさんも死んじゃって<br>ガウェインさんもいなくなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020008")


	--★★ディナタン★★:…ランス兄ちゃん、言ってたよね<br>「俺とお前の選択が間違っていたから」って
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン、止めろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020011")


	--★★ディナタン★★:止めないよ<br>兄さんだってわかってるはずでしょ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:兄さんが選んだのは私
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020014")


	--★★ディナタン★★:私が兄さんとGSしちゃったから<br>みんな、こうなったんじゃないの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020015")

	open_select_window_tag(Actor001,"Normal","MA_01C201_020016","MA_01C201_020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン、それは違う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:お前がいなかったら俺はここまで来られなかった<br>魔女やライエンスに喰われて終わってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020020")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:お前を選んだことを間違いだとは思わない<br>俺の武器はディナタンだけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020021")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:やだな。誘導したみたいになっちゃった<br>兄さんにそう言ってもらえると安心するから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020023")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…でも、おかしいな<br>前はもっと素直に喜べたのに――…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ランスロットはいつも俺とディナタンを支え<br>そして導いてくれていた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:スノードンのときだってそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020027")

	change_face(Actor001,"Sad")

	--★★ノワール★★:俺が『本当』に辿り着くために<br>…命をかけてくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアもきっと同じだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だから、俺たちは進まなきゃ<br>悲しんでばかりいちゃダメなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020030")

	change_face(Actor001,"Normal")

	--★★ノワール★★:継がないと<br>ふたりの想いを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020031")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.4)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それ、は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020034")

-- ▼直接出力
 setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020036")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat_object(Actor002,nil,"kara2",0.5)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:………
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_020038")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
show_image("101040250", 0.0, 0.0, 0,true,false)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
hide_image(0)
se_play("SE_ADV_MA_01B109_11_Door")
wait_time(CHARA_IN_WAIT)
on_active(Actor003)
turn_lookat_position(Actor003,CharaPos110141_02_007[1],CharaPos110141_02_007[2],CharaPos110141_02_007[3],0)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,CharaPos110141_02_007[1],CharaPos110141_02_007[2],CharaPos110141_02_007[3],1.5)
setup_small_camera_start(RndCamera004)
wait_time(0.2)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(1.3)
turn_chara(Actor003,CharaPos110141_02_007[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:いたいた、ディーナ<br>階段で転んじまってさ、薬を分けてくれよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C201_020040")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:オニーサンもいたのか<br>どした？ふたりして沈んだカオして
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C201_020041")

-- ▼直接出力
 setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --lookat_delay_weight_reset(Actor001,0.6)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:パーッとメシでも食いにいくか？<br>アタシは金出せねーけど
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C201_020042")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,185,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
--lookat_delay_weight(Actor001, 0.6, 0, 0.8, 0.2,1.0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、俺は遠慮しとくよ<br>ふたりで仲良く行ってきたらいい?
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_020043")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
lookWeight = {0.9, 0, 0.6, 0.35}
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101040250", "content_still_10104025_image", "101040250_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115150)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
