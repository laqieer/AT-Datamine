-- このluaスクリプトは、MA_01107_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera007 = SetTemplate("Actor007",-50,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("102010070_StillImage", "content_still_10201007_image", "102010070_StillImage")
set_pos(Actor003,{-0.2,0.128,23.5})
set_rot(Actor003,{0,-130,0})
set_pos(Actor006,{0.8,0.128,22.8})
set_rot(Actor006,{0,-110,0})
Hide(Actor007)
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor007,Actor001,"J_Head")
keep_ik_lookat(Actor008,Actor001,"J_Head")
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115081)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01107_211001")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01107_211002")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01107_211003")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01107_211004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:なかなか難敵であることを<br>いやというほどわからされた
	Talk(Actor009,"telop","narration","N","MA_01107_211005")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★皇帝ルーシャス★★:なかなか難敵であることを<br>いやというほどわからされた
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210002")

	PlayAction(Actor004,"to  Std_Appl")
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:賞賛に値するほどだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:本音を言えば…正直、もはやちょっぴり、若干<br>貴様らに協力してやりたい気持ちが大きいが
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210004")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Sad")

	--★★皇帝ルーシャス★★:たびたびフラれてバツが悪い<br>早くクリアして協力させてくれ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:早くクリアできるほど<br>簡単な進路じゃないと思うけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_210007")

-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:クッククク…<br>それはまあそうであるな？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210008")

	PlayAction(Actor006,"to  Std_Talk")

	--★★トリスタン★★:皇太子殿下、これからどちらへ向かうんです？<br>ボクとイゾルデは聞いてないのですが…
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_210009")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:敵情視察であると申したはずだが？<br>確かスノードン山の付近までであったか
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210010")

-- ▼直接出力
CloseTalkWindow()
show_image("102010070_StillImage", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★トリスタン★★:えっ！？カレドニア領のど真ん中だよね！？<br>なんで！？どういう話の流れでそーなったの！？
	Talk(Actor006,"CHRNAME_TRISTAN","simple","N","MA_01107_210012")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) 
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:わたし今回パスね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_210014")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★皇帝ルーシャス★★:またフラれたよ、これだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210016")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ギネヴィア★★:キャメリアードの鉱山をね<br>もう少し見てみよっかなって思って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_210017")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:キャメリアードならどこであっても<br>パパを思い出しちゃって、それ案外悪くなくって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_210018")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:その代わりと言ってはなんだけど──
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_210019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor008,Camera008,EntryData110071_01_07,CameraAssetBundleName110071_01,CameraPos110071_01_107,Actor007,CharaPos110071_01_006,CharaPos110071_01_106)
-- ▲直接出力
	PlayAction(Actor008,"to Greet_one")
-- ▼直接出力
set_rot(Actor001,{0,-150,0})
set_rot(Actor002,{0,-115,0})
set_rot(Actor003,{0,-150,0})
set_rot(Actor004,{0,135,0})
set_rot(Actor005,{0,140,0})
set_rot(Actor006,{0,-120,0})
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★マルディサント★★:オニーサン、これからどちらまで～？
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","MA_01107_210021")

	PlayAction(Actor007,"to Greet_one")
-- ▼直接出力
DontChangeRandomCamera(false)
keep_delay_ik_lookat(Actor001,Actor007,"J_Head",1)
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ディナタン★★:兄さん、私たちも連れて行って
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210022")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
change_face(Actor007,"Normal")
change_face(Actor008,"Normal")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタン、マルディサント<br>危険だ…前の戦いのキズも癒えてないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_210023")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★ディナタン★★:ブライアンさんの怪我が落ち着いたの
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210024")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Laugh")

	--★★マルディサント★★:ディーナの歌が効いたな、ありゃ<br>あのオッサン気持ちよさそうに寝やがって
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","MA_01107_210025")

-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor008,"J_Head",1)
PlayActionDirect(Actor007,"to  Std_Talk")
turn_chara(Actor007,-100,0.5)
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ディナタン★★:マァルにも歌ってあげようか？
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210026")

	PlayAction(Actor008,"to  Std_Talk")
	change_face(Actor008,"Smile")

	--★★マルディサント★★:寝かしつけてくれんのかよ<br>たまんねえな
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","MA_01107_210027")

	PlayAction(Actor006,"to  Std_Worry")
	change_face(Actor006,"Sad")

	--★★トリスタン★★:…いちゃいちゃしないで欲しいね
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_210028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor007,"Normal")
change_face(Actor008,"Normal")
keep_delay_ik_lookat(Actor007,Actor001,"J_Head",1)
PlayActionDirect(Actor007,"to  Std_Joy")
turn_chara(Actor007,-55,0.3)
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ディナタン★★:あッ、えーっと、コホン！<br>兄さんのお手伝い、私にもさせて
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210029")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:時間が惜しい。すぐにでも出かけようか<br>GSが済んだ生徒が増えるのは頼もしいかぎりだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210030")

	PlayAction(Actor007,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★ディナタン★★:よ、よ、よよろしくおねがいいたします…<br>ルーシャス皇太子殿下…！
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210032")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:クッククク…、おぼこな娘だ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210033")


	--★★ディナタン★★:お、おぼ…？
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Angry")
	change_face(Actor008,"Anger")

	--★★マルディサント★★:オォイ！皇太子だかローマだか知れねえが<br>ディーナに手ェ出したらキャンじゃすまねえぞ
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","MA_01107_210035")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:バルバロイが出たら護衛を頼みたい<br>見せてくれるな？新たなキラーズの力を
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_210036")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	open_cutin(1,1)
	on_cutin(1,Actor008,"Anger")

	--★★マルディサント★★:見てろ任せろオラァッ！
	Talk(Actor008,"CHRNAME_MALADISANT","speech","N","MA_01107_210038")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor001,"J_Head",1)
keep_delay_ik_lookat(Actor008,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ディナタン★★:兄さん
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210040")

	open_select_window_tag(Actor001,"Normal","MA_01107_210042","MA_01107_210043")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ディナタン、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_210045")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:見せてもらうよ<br>ディナタンとマルディサントの力を
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_210046")

-- ▼直接出力
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to Finger")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ディナタン★★:うん！期待…
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210047")

	PlayAction(Actor008,"to Finger")
	on_cutin(2,Actor008,"Smile")
	change_face(Actor008,"Smile")

	--★★マルディサント★★:…してくれていいぜ！
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","MA_01107_210048")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:くれぐれも無理はするなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_210050")

	change_face(Actor001,"Normal")

	--★★ノワール★★:危なくなったらすぐ俺の…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_210051")

	PlayAction(Actor008,"to  Std_Talk")
	change_face(Actor008,"Laugh")

	--★★マルディサント★★:ディーナはＧＳを済ませてんだぜ？<br>バルバロイ相手ならオニーサンより強えって
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","MA_01107_210052")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Surprise")

	--★★ディナタン★★:そ、そんなことは…
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210054")

	change_face(Actor007,"Smile")

	--★★ディナタン★★:ある、かも
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210056")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor007,"to Std_Loop")
change_face(Actor007,"Normal")
change_face(Actor008,"Normal")
set_enable_auto_lookat_all(true)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Worry")
	change_face(Actor007,"Normal")

	--★★ディナタン★★:私、ずっと兄さんの背中についてきたけど<br>やっと並んで歩ける気がするんだ
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210058")


	--★★ディナタン★★:それでね？傭兵団でずっと兄さんが<br>守ってくれたから今の私がいる
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210059")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:だから今度は私が<br>兄さんの盾になるから
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210060")

-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ディナタン★★:安心して。兄さん
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01107_210062")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010070_StillImage", "content_still_10201007_image", "102010070_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115081)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor008")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
