-- このluaスクリプトは、MA_01C110_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110131_01","110131_01_h")
Include("content_adv_advsmall_110131_01","Template110131_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110131_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110131_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110131_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110131_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_006)
	InitializeTemplateRandomCamera110131_01()
	InitializeTemplate110131_01()
-- ▼直接出力
show_image("103010010", 0.0, 0.0, 0.0) --回想スチルを表示
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
Hide(Actor003)
Hide(Actor004)
set_pos(Actor003,CharaPos110131_01_101)
set_pos(Actor004,CharaPos110131_01_106)

-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon_D")
load_sound("VO_story01")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110131)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101026","001","101026001")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:…戦時に祭りなど、とお思いですか？
	Talk(Actor006,"","narration","L","MA_01C110_390002")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Noon_D")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:なにぼんやりしてるんだ、ノワール
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:五月祭のことを思い出していた
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390005")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ランスロット★★:…あのときはまだみんないたな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390006")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:あの頃はこんなことになるなんて<br>思いもしなかった
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390008")


	--★★ノワール★★:なにもかも変わってしまった<br>…あんたはわかってたのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390009")

	change_face(Actor001,"Normal")

	--★★ランスロット★★:まさか。俺はお前が思うほど<br>なんでも知ってるわけじゃない
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390010")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ランスロット★★:もしそう見えるとしたら<br>ただの意地だよ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:…意地？なんの？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ランスロット★★:気にするな。こっちの話だ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390014")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:それにしても…ふたりとも遅いな<br>露店を見てくると言っていたが…
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390015")

-- ▼直接出力
CloseTalkWindow()
IN_RUN_2P(Actor003,CharaPos110131_01_001,Actor004,CharaPos110131_01_006)
turn_chara(Actor001,140.5,0.5)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor002,-130,0.5)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:ぜぇ…ぜぇ…<br>ま、間に合った～！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_390017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:いろんな露店が出てるから<br>つい見て回っちゃって
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_390018")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ギネヴィア★★:危うくディナタンに<br>ステージをすっぽかさせるとこだった！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_390019")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:おいおい、しっかりしてくれ<br>キミが誘ったんだろ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390021")


	--★★ギネヴィア★★:わ、悪かったってば～！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_390022")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディナタン★★:そんなこと言わないで、兄さん<br>私も楽しんでたんだから
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:ディナタン天使！！<br>ノワールもちょっとは見習ってよねぇ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_390024")


	--★★ディナタン★★:天才から天使になっちゃった
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:そろそろ出番だな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディナタン★★:うん…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390027")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★ディナタン★★:…本当にいいのかな<br>私がステージで歌うなんて
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390028")


	--★★ディナタン★★:だって私たち<br>学園が大変なときにいなかったのに
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:いいに決まってるじゃない<br>なんたって五月女王よ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_390030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ランスロット★★:ああ。みんな楽しみにしてる
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390031")


	--★★ディナタン★★:…でも
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ランスロット★★:ディナタンは変わらないな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390033")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ディナタン★★:…えっ？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ランスロット★★:ちょっと自信がなくてでもいつも昔から<br>変わらずノワールのそばにいる
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C110_390035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ディナタン★★:兄さんのそばにいるのは変わらないけど…<br>でも、どう思う？兄さん
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390036")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002, {0.7, 0.08, 0.8, 0.6})
keep_delay_ik_lookat(Actor002,Actor004, "J_Head", 0.7)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01C110_390037","MA_01C110_390038")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:変わらないよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390040")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-30,0.3)
wait_time(0.3)
lookat_weight(Actor004, {0.7, 0.08, 0.8, 0.6})
keep_delay_ik_lookat(Actor004,Actor002, "J_Head", 0.7)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ディナタン★★:ちょっとは大人になってるって<br>言ってくれてもいいのに
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:妹は妹のままだからな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390042")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディナタン★★:そうだね、妹のまま<br>私は兄さんの武器になったんだもんね
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390043")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ディナタン★★:それはずっと変わらない
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390044")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:変わったよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390046")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-30,0.3)
wait_time(0.3)
lookat_weight(Actor004, {0.7, 0.08, 0.8, 0.6})
keep_delay_ik_lookat(Actor004,Actor002, "J_Head", 0.7)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディナタン★★:どのへんが変わった？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390047")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:妹のままなのは変わらないけど<br>強くなったし大人になった
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390048")

	change_face(Actor004,"Normal")

	--★★ディナタン★★:私、強くなったかな
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:当たり前だろ<br>俺の武器なんだから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390050")

	goto Block1end

::Block1end::
	change_face(Actor002,"Smile")

	--★★ノワール★★:行っておいで、ディナタン
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_390052")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディナタン★★:…うん<br>頑張ってくるね、私！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390053")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力

	--★★パーシヴァル★★:…さぁ、学園祭もいよいよクライマックス！<br>ラストはみなさんお待ちかね！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_390055")


	--★★パーシヴァル★★:ログレスのアイドル、可憐な歌姫<br>五月女王ディナタンの登場だ！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_390056")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01C110_39_Cheers")
wait_time(2.8)
lookat_delay_weight_reset(Actor004,0.7)
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Anger")

	--★★ディナタン★★:…よし！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390058")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ディナタン★★:行ってきます！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01C110_390059")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_Area_Noon_D")
preload_sound("VO_story01")
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(110131)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101026","001","101026001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110131_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
